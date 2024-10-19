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
            TumTariflerinMaliyetleriniHesaplaVeListele();
        }
        private float HesaplaToplamMaliyet(int selectedTarifID)
        {
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";

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
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzemeler yüklenirken bir hata oluştu: " + ex.Message);
                    return -1; // Hata durumunda -1 döndürür
                }
            }

            if (malzemeMiktarListesi.Count == 0)
            {
                MessageBox.Show("Bu tarif için malzeme bulunamadı.");
                return -1;
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
                        }
                        else
                        {
                            MessageBox.Show("Birim fiyat bulunamadı: MalzemeID " + malzeme.Item1);
                            return -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Birim fiyat hesaplanırken bir hata oluştu: " + ex.Message);
                        return -1;
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
                return -1;
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
                    return -1;
                }
            }

            // Toplam maliyeti hesapla
            float toplamMaliyet = 0;
            foreach (var fiyatMiktar2 in finalList)
            {
                toplamMaliyet += fiyatMiktar2.Item1 * fiyatMiktar2.Item2;
            }

            // Toplam maliyeti geri döndür
            return toplamMaliyet;
        }
        private void TumTariflerinMaliyetleriniHesaplaVeListele()
        {
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";

            // TarifID'leri saklamak için liste
            List<int> tarifIDListesi = new List<int>();

            // Tbl_Tarifler tablosundan tüm TarifID'leri çek
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryTarifler = "SELECT TarifID FROM Tbl_Tarifler";
                SqlCommand command = new SqlCommand(queryTarifler, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int tarifID = reader.GetInt32(0);
                        tarifIDListesi.Add(tarifID); // TarifID'yi listeye ekle
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarifler yüklenirken bir hata oluştu: " + ex.Message);
                    return;
                }
            }

            // ListBox'ı temizle (önceki verileri temizlemek için)
            listBox1.Items.Clear();

            // Her bir tarif için maliyet hesapla ve ListBox'a ekle
            foreach (int tarifID in tarifIDListesi)
            {
                float maliyet = HesaplaToplamMaliyet(tarifID); // Metotu çağır ve maliyeti hesapla

                if (maliyet != -1) // Hata durumu olmayanları ekle
                {
                    // ListBox'a TarifID ve maliyeti yazdır
                    listBox1.Items.Add("Tarif ID: " + tarifID + " - Toplam Maliyet: " + maliyet.ToString("0.00") + " TL");
                }
                else
                {
                    listBox1.Items.Add("Tarif ID: " + tarifID + " - Maliyet hesaplanamadı.");
                }
            }
        }


    }
}
