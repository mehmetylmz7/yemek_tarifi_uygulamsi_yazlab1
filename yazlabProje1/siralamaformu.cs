using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace yazlabProje1
{
    public partial class siralamaformu : Form
    {
        public siralamaformu()
        {
            InitializeComponent();
        }

        private void siralamaformu_Load(object sender, EventArgs e)
        {
            CalculateTarifMaliyet();
        }

        private void CalculateTarifMaliyet()
        {
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";
            string query = "SELECT TarifID FROM Tbl_Tarifler"; // Tüm tariflerin ID'lerini al

            List<string> tarifMaliyetList = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int tarifID = reader.GetInt32(0);
                        float toplamMaliyet = CalculateMaliyetForTarif(tarifID);
                        tarifMaliyetList.Add($"Tarif ID: {tarifID}, Toplam Maliyet: {toplamMaliyet.ToString("0.00")} TL");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Maliyet hesaplanırken bir hata oluştu: " + ex.Message);
                }
            }

            // Maliyet listesini ListBox veya DataGridView'e ekle
            foreach (var item in tarifMaliyetList)
            {
                listBox1.Items.Add(item); // listBox1'iniz varsa
            }
        }

        private float CalculateMaliyetForTarif(int tarifID)
        {
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";
            float toplamMaliyet = 0;

            // Malzemeleri ve miktarları al
            string queryMalzemeler = "SELECT MalzemeID, CAST(MalzemeMiktar AS VARCHAR) AS MalzemeMiktar FROM Tbl_TarifMalzeme_iliskisi WHERE TarifID = @TarifID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryMalzemeler, connection);
                command.Parameters.AddWithValue("@TarifID", tarifID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    List<Tuple<int, string>> malzemeMiktarListesi = new List<Tuple<int, string>>();

                    while (reader.Read())
                    {
                        int malzemeID = reader.GetInt32(0);
                        string malzemeMiktarStr = reader.GetString(1); // Miktarı string olarak al
                        malzemeMiktarListesi.Add(new Tuple<int, string>(malzemeID, malzemeMiktarStr));
                    }
                    reader.Close();

                    // Birim fiyatları al ve toplam maliyeti hesapla
                    foreach (var malzeme in malzemeMiktarListesi)
                    {
                        float birimFiyat = GetBirimFiyat(malzeme.Item1); // MalzemeID'ye göre birim fiyatı al
                        if (float.TryParse(malzeme.Item2, out float malzemeMiktar)) // Miktarı float'a çevir
                        {
                            toplamMaliyet += birimFiyat * malzemeMiktar;
                        }
                        else
                        {
                            MessageBox.Show($"Malzeme miktarı '{malzeme.Item2}' dönüştürülemedi: Lütfen geçerli bir değer girin.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzeme hesaplanırken bir hata oluştu: " + ex.Message);
                }
            }

            return toplamMaliyet;
        }

        private float GetBirimFiyat(int malzemeID)
        {
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";
            string queryBirimFiyat = "SELECT CAST(BirimFiyat AS VARCHAR) AS BirimFiyat FROM Tbl_Malzemeler WHERE MalzemeID = @MalzemeID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryBirimFiyat, connection);
                command.Parameters.AddWithValue("@MalzemeID", malzemeID);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return float.Parse(result.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Birim fiyat alınırken bir hata oluştu: " + ex.Message);
                }
            }

            return 0; // Fiyat bulunamazsa 0 döner
        }
    }
}
