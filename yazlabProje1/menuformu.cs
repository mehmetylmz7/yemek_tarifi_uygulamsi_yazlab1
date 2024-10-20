using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazlabProje1
{
    public partial class menuformu : Form
    {
        public menuformu()
        {
            InitializeComponent();
        }

        private void menuformu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazlab1_tarifDataSet2.Tbl_Tarifler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_TariflerTableAdapter.Fill(this.yazlab1_tarifDataSet2.Tbl_Tarifler);
            textBox7.TextChanged += new EventHandler(textBox7_TextChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VerileriYenile()
        {
            // Veritabanından verileri tekrar çekerek DataGridView'i güncelle
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Tarifler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox ve ComboBox'ların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                comboBox1.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına ekleme işlemi, son eklenen TarifID'yi alıyoruz
            // Insert komutunu düzeltelim
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Tarifler (TarifAdi, Kategori, HazirlanmaSuresi, Talimatlar) OUTPUT INSERTED.TarifID VALUES (@p1, @p2, @p3, @p4)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            komut.Parameters.AddWithValue("@p4", textBox3.Text);

            // Eklenen tarife ait ID'yi al
            int addedRecipeId = (int)komut.ExecuteScalar();

            bgl.baglanti().Close();

            // Verileri yenile
            VerileriYenile();

            // Yeni tarif ID'sini diğer forma geçir
            tarifmalzemeform tarifmalzemeform = new tarifmalzemeform(addedRecipeId);
            tarifmalzemeform.Show();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           string tarifadi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string kategori = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string hazirlanmasuresi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string talimatlar= dataGridView1.CurrentRow.Cells[3].Value.ToString();

            textBox6.Text = tarifadi;
            comboBox2.Text = kategori;
            textBox5.Text = hazirlanmasuresi;
            textBox4.Text = talimatlar;    

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Önce bir onay mesajı göster
            DialogResult result = MessageBox.Show("Bu tarifi silmek istediğinizden emin misiniz?",
                                                  "Silme Onayı",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // Kullanıcı 'Evet' butonuna basarsa silme işlemi başlasın
            if (result == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Tarifler WHERE TarifAdi = @p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox6.Text); // Tarif adını alıyoruz
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                // DataGridView'i güncelle
                VerileriYenile();

                // Kullanıcıya bilgi mesajı ver
                MessageBox.Show("Tarif başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SQL UPDATE sorgusu ile veritabanındaki tarifi güncelle
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Tarifler SET Kategori = @p1, HazirlanmaSuresi = @p2, Talimatlar = @p3 WHERE TarifAdi = @p4", bgl.baglanti());

            // Yeni bilgileri parametre olarak ekliyoruz
            komut.Parameters.AddWithValue("@p1", comboBox2.Text);  // Güncellenen kategori
            komut.Parameters.AddWithValue("@p2", textBox5.Text);   // Güncellenen hazırlık süresi
            komut.Parameters.AddWithValue("@p3", textBox4.Text);   // Güncellenen talimatlar
            komut.Parameters.AddWithValue("@p4", textBox6.Text);   // Tarif adı (güncellenecek tarif)

            // Komutu çalıştır
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            // Güncellemeden sonra DataGridView'i yenile
            VerileriYenile();

            // Başarı mesajı göster
            MessageBox.Show("Tarif başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }
        private void AramaYap()
        {
            DataTable table = new DataTable(); // Yeni bir DataTable oluştur
            table.Clear(); // Daha önceki verileri temizle

            try
            {
           //     bgl.baglanti().Open(); // Bağlantıyı aç

                // SQL sorgusu, textBox7'ye girilen kelimeyi kullanarak LIKE ile filtreler
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Tbl_Tarifler WHERE TarifAdi LIKE @arama OR Kategori LIKE @arama OR HazirlanmaSuresi LIKE @arama OR Talimatlar LIKE @arama", bgl.baglanti());

                // Parametreleri ekle
                adtr.SelectCommand.Parameters.AddWithValue("@arama", "%" + textBox7.Text + "%"); // Parametreli arama

                adtr.Fill(table); // DataTable'a verileri doldur
                dataGridView1.DataSource = table; // DataGridView'e verileri bağla
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close(); // Bağlantıyı kapat
            }
        }

    }
}
