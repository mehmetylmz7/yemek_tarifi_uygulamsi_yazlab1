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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yazlabProje1
{
    public partial class MalzemeForm : Form
    {
        public MalzemeForm()
        {
            InitializeComponent();
        }

        private void MalzemeForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazlab1_tarifDataSet3.Tbl_Malzemeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_MalzemelerTableAdapter.Fill(this.yazlab1_tarifDataSet3.Tbl_Malzemeler);
            VerileriYenile();


        }



        private void VerileriYenile()
        {
            // Veritabanından verileri tekrar çekerek DataGridView'i güncelle
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Malzemeler", bgl2.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        sqlbaglantisi bgl2= new sqlbaglantisi();

        private void tarifeklebutonu_Click(object sender, EventArgs e)
        {
            // Aynı isimde malzeme var mı kontrol et
            SqlCommand kontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM Tbl_Malzemeler WHERE MalzemeAdi=@p1", bgl2.baglanti());
            kontrolKomutu.Parameters.AddWithValue("@p1", textBox1.Text);
            int malzemeSayisi = (int)kontrolKomutu.ExecuteScalar();

            // Eğer aynı isimde bir malzeme varsa hata mesajı göster
            if (malzemeSayisi > 0)
            {
                MessageBox.Show("Bu malzeme zaten var! Lütfen farklı bir malzeme adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Eğer aynı isimde malzeme yoksa ekleme işlemi yapılır
                SqlCommand komut = new SqlCommand("insert into Tbl_Malzemeler (MalzemeAdi,MalzemeBirim,ToplamMiktar,BirimFiyat) values (@p1,@p2,@p3,@p4)", bgl2.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", comboBox1.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@p3", textBox2.Text);
                komut.Parameters.AddWithValue("@p4", textBox3.Text);
                komut.ExecuteReader();
                bgl2.baglanti().Close();

                VerileriYenile();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string malzemeadi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string birimturu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string toplammiktar = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string birimfiyat = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            textBox1.Text = malzemeadi;
            comboBox1.Text = birimturu;
            textBox2.Text = toplammiktar;
            textBox3.Text = birimfiyat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox ve ComboBox'lardaki verileri temizle
            textBox1.Text = ""; // Malzeme Adı
            comboBox1.SelectedIndex = -1; // ComboBox'taki seçim iptal edilir (boş olur)
            textBox2.Text = ""; // Toplam Miktar
            textBox3.Text = ""; // Birim Fiyat
        }
    }
}
