using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            // Tbl_Tarifler tablosundan verileri ComboBox'a yükle.
            this.tbl_TariflerTableAdapter.Fill(this.yazlab1_tarifDataSet7.Tbl_Tarifler);
            LoadTarifler();
        }

        private void LoadTarifler()
        {
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";
            string query = "SELECT TarifID, TarifAdi FROM Tbl_Tarifler ORDER BY TarifAdi";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    comboBox1.DataSource = dataTable;
                    comboBox1.DisplayMember = "TarifAdi";
                    comboBox1.ValueMember = "TarifID";

                    comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            int selectedTarifID = Convert.ToInt32(comboBox1.SelectedValue);

            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";

            // 2. Tbl_TarifMalzeme_iliskisi tablosundan seçilen TarifID'ye göre MalzemeID'leri al.
            string queryMalzemeIDs = "SELECT MalzemeID FROM Tbl_TarifMalzeme_iliskisi WHERE TarifID = @TarifID";

            List<int> malzemeIDList = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryMalzemeIDs, connection);
                command.Parameters.AddWithValue("@TarifID", selectedTarifID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // 3. Tüm MalzemeID'leri listeye ekliyoruz.
                    while (reader.Read())
                    {
                        malzemeIDList.Add(reader.GetInt32(0));
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
                        richTextBox1.Clear();
                        richTextBox1.AppendText("Kullanılan Malzemeler:\n");

                        while (reader.Read())
                        {
                            richTextBox1.AppendText(reader.GetString(0) + "\n");
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
                command.Parameters.AddWithValue("@TarifID", selectedTarifID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        richTextBox2.Clear();
                        richTextBox2.AppendText(reader.GetString(0));
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

        private void button2_Click(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen TarifID'yi al
            int selectedTarifID = Convert.ToInt32(comboBox1.SelectedValue);
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";
            MessageBox.Show("Selected Tarif ID: " + selectedTarifID); // Debug için

            // İlk liste: Tbl_TarifMalzeme_iliskisi tablosundan MalzemeID ve MalzemeMiktarlarını al (int, string)
            List<Tuple<int, string>> malzemeMiktarListesi = new List<Tuple<int, string>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryMalzemeler = "SELECT MalzemeID, CAST(MalzemeMiktar AS VARCHAR) AS MalzemeMiktar FROM Tbl_TarifMalzeme_iliskisi WHERE TarifID = @TarifID";
                SqlCommand command = new SqlCommand(queryMalzemeler, connection);
                command.Parameters.AddWithValue("@TarifID", selectedTarifID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int malzemeID = reader.GetInt32(0);
                        string malzemeMiktarStr = reader.GetString(1);
                        malzemeMiktarListesi.Add(new Tuple<int, string>(malzemeID, malzemeMiktarStr));
                        MessageBox.Show("MalzemeID: " + malzemeID + ", MalzemeMiktar: " + malzemeMiktarStr); // Debug için
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzemeler yüklenirken bir hata oluştu: " + ex.Message);
                    return;
                }
                if (malzemeMiktarListesi.Count == 0)
                {
                    MessageBox.Show("Bu tarif için malzeme bulunamadı.");
                    return;
                }
            }

            // İkinci liste: MalzemeID'leri kullanarak Tbl_Malzemeler tablosundan BirimFiyat ve MalzemeMiktarlarını al (string, string)
            List<Tuple<string, string>> fiyatMiktarListesi = new List<Tuple<string, string>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                foreach (var malzeme in malzemeMiktarListesi)
                {
                    string queryBirimFiyat = "SELECT CAST(BirimFiyat AS VARCHAR) AS BirimFiyat FROM Tbl_Malzemeler WHERE MalzemeID = @MalzemeID";
                    SqlCommand command = new SqlCommand(queryBirimFiyat, connection);
                    command.Parameters.AddWithValue("@MalzemeID", malzeme.Item1);

                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string birimFiyatStr = result.ToString();
                            fiyatMiktarListesi.Add(new Tuple<string, string>(birimFiyatStr, malzeme.Item2));
                            MessageBox.Show("BirimFiyat: " + birimFiyatStr + ", MalzemeMiktar: " + malzeme.Item2); // Debug için
                        }
                        else
                        {
                            MessageBox.Show("Birim fiyat bulunamadı: MalzemeID " + malzeme.Item1);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Birim fiyat hesaplanırken bir hata oluştu: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            if (fiyatMiktarListesi.Count == 0)
            {
                MessageBox.Show("Birim fiyatlar bulunamadı.");
                return;
            }

            // Üçüncü liste: String değerleri floata dönüştür ve ekle (float, float)
            List<Tuple<float, float>> finalList = new List<Tuple<float, float>>();
            foreach (var fiyatMiktar in fiyatMiktarListesi)
            {
                try
                {
                    float birimFiyat = float.Parse(fiyatMiktar.Item1, System.Globalization.CultureInfo.InvariantCulture);
                    float malzemeMiktar = float.Parse(fiyatMiktar.Item2, System.Globalization.CultureInfo.InvariantCulture);
                    finalList.Add(new Tuple<float, float>(birimFiyat, malzemeMiktar));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Değerler dönüştürülürken bir hata oluştu: " + ex.Message);
                    return;
                }
            }

            // Toplam maliyeti hesapla
            float toplamMaliyet = 0;
            foreach (var fiyatMiktar2 in finalList)
            {
                toplamMaliyet += fiyatMiktar2.Item1 * fiyatMiktar2.Item2;
                MessageBox.Show("BirimFiyat: " + fiyatMiktar2.Item1 + ", MalzemeMiktar: " + fiyatMiktar2.Item2 + ", Şu anki toplam maliyet: " + toplamMaliyet); // Debug için
            }

            // Toplam maliyeti richTextBox3'e yazdır
            richTextBox3.Clear();
            richTextBox3.AppendText("Toplam Maliyet: " + toplamMaliyet.ToString("0.00") + " TL");
        }


    }
}
