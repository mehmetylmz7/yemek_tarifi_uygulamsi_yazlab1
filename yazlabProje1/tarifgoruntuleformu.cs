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
    public partial class tarifgoruntuleformu : Form
    {
        public tarifgoruntuleformu()
        {
            InitializeComponent();
        }

        private void tarifgoruntuleformu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazlab1_tarifDataSet7.Tbl_Tarifler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_TariflerTableAdapter.Fill(this.yazlab1_tarifDataSet7.Tbl_Tarifler);
            LoadTarifler();

        }

        private void LoadTarifler()
        {
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";
            string query = "SELECT TarifID, TarifAdi FROM Tbl_Tarifler ORDER BY TarifAdi";

            DataTable dataTable = new DataTable(); // Verileri depolamak için bir DataTable oluşturun.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open(); // Bağlantıyı açın.
                    SqlDataAdapter adapter = new SqlDataAdapter(command); // SqlDataAdapter ile verileri çekin.
                    adapter.Fill(dataTable); // DataTable'a verileri doldurun.

                    // ComboBox'ı DataSource ile doldurun.
                    comboBox1.DataSource = dataTable;
                    comboBox1.DisplayMember = "TarifAdi"; // Gösterilecek sütun
                    comboBox1.ValueMember = "TarifID"; // Değer olarak kullanılacak sütun

                    // Otomatik tamamlama özelliklerini ayarlayın.
                    comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Kullanıcı yazarken öneri yap.
                    comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems; // Liste öğelerinden öneri yap.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. ComboBox'tan seçilen TarifID'yi alın.
            int selectedTarifID = Convert.ToInt32(comboBox1.SelectedValue); // Seçilen tarifin ID'sini alıyoruz.

            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";

            // 2. Tbl_TarifMalzeme_iliskisi tablosundan seçilen TarifID'ye göre MalzemeID'leri al.
            string queryMalzemeIDs = "SELECT MalzemeID FROM Tbl_TarifMalzeme_iliskisi WHERE TarifID = @TarifID";

            List<int> malzemeIDList = new List<int>(); // MalzemeID'leri tutmak için bir liste oluşturuyoruz.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryMalzemeIDs, connection);
                command.Parameters.AddWithValue("@TarifID", selectedTarifID); // TarifID'yi sorguya ekliyoruz.

                try
                {
                    connection.Open(); // Bağlantıyı açıyoruz.
                    SqlDataReader reader = command.ExecuteReader();

                    // 3. Tüm MalzemeID'leri listeye ekliyoruz.
                    while (reader.Read())
                    {
                        malzemeIDList.Add(reader.GetInt32(0)); // İlk sütun olan MalzemeID'yi al ve listeye ekle.
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzemeler yüklenirken bir hata oluştu: " + ex.Message);
                    return;
                }
            }

            // 4. Tbl_Malzemeler tablosundan MalzemeID'lere karşılık gelen MalzemeAdi'leri al.
            if (malzemeIDList.Count > 0)
            {
                string queryMalzemeAdlari = "SELECT MalzemeAdi FROM Tbl_Malzemeler WHERE MalzemeID IN (" + string.Join(",", malzemeIDList) + ")";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryMalzemeAdlari, connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // richTextBox1'e malzemeleri yazıyoruz.
                        richTextBox1.Clear(); // Önce içeriği temizleyelim.
                        richTextBox1.AppendText("Kullanılan Malzemeler:\n");

                        while (reader.Read())
                        {
                            richTextBox1.AppendText(reader.GetString(0) + "\n"); // MalzemeAdi'ni ekliyoruz.
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Malzeme adları yüklenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("Bu tarif için malzeme bulunamadı.");
            }

            // 5. Tbl_Tarifler tablosundan Talimatları al ve richTextBox2'ye yazdır.
            string queryTalimatlar = "SELECT Talimatlar FROM Tbl_Tarifler WHERE TarifID = @TarifID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryTalimatlar, connection);
                command.Parameters.AddWithValue("@TarifID", selectedTarifID); // Seçilen TarifID'yi ekliyoruz.

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Talimatları richTextBox2'ye yazdırıyoruz.
                        richTextBox2.Clear();
                        richTextBox2.AppendText(reader.GetString(0)); // Talimatlar sütununu yazdırıyoruz.
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Talimatlar yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
