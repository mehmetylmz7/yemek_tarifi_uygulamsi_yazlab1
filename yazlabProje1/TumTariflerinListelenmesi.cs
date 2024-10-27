using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Gerekli ad alanı
using System.Drawing;
using System.Windows.Forms;

namespace yazlabProje1
{
    public partial class TumTariflerinListelenmesi : Form
    {
        public TumTariflerinListelenmesi()
        {
            InitializeComponent();
        }

        private void TumTariflerinListelenmesi_Load(object sender, EventArgs e)
        {
            this.tbl_TariflerTableAdapter4.Fill(this.yazlab1_tarifDataSet17.Tbl_Tarifler);
            this.tbl_TariflerTableAdapter3.Fill(this.yazlab1_tarifDataSet16.Tbl_Tarifler);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Eğer hiç satır seçilmemişse çık
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            // Seçilen satırdan TarifID'yi al
            int selectedTarifID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); // İlk sütun

            // Talimatları almak için gerekli bağlantı
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";

            // Talimatları alacak sorgu
            string queryTalimatlar = "SELECT Talimatlar FROM Tbl_Tarifler WHERE TarifID = @TarifID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commandTalimatlar = new SqlCommand(queryTalimatlar, connection);
                commandTalimatlar.Parameters.AddWithValue("@TarifID", selectedTarifID);

                try
                {
                    connection.Open();
                    SqlDataReader readerTalimatlar = commandTalimatlar.ExecuteReader();

                    // Eğer talimat varsa, RichTextBox'a yaz
                    if (readerTalimatlar.Read())
                    {
                        richTextBox1.Clear(); // Önceki içeriği temizle
                        richTextBox1.AppendText(readerTalimatlar.GetString(0)); // Talimatları yazdır
                    }
                    readerTalimatlar.Close();

                    // Maliyeti hesapla
                    float toplamMaliyet = HesaplaToplamMaliyet(selectedTarifID); // Mevcut metodu kullan

                    // Maliyeti TextBox'a yaz
                    if (toplamMaliyet >= 0) // Eğer -1 döndürmediyse
                    {
                        textBox1.Clear(); // Önceki içeriği temizle
                        textBox1.AppendText(toplamMaliyet.ToString("C2")); // Maliyeti yazdır (para birimi formatında)
                    }
                    else
                    {
                        textBox1.Clear();
                        textBox1.AppendText("Maliyet bulunamadı."); // Eğer maliyet yoksa
                    }

                    // Fotoğrafı PictureBox'a yükle
                    if (FotoClass.FotoDictionary.TryGetValue(selectedTarifID, out string fotoYolu) && System.IO.File.Exists(fotoYolu))
                    {
                        pictureBox1.ImageLocation = fotoYolu;
                        pictureBox1.Image=Image.FromFile(fotoYolu);
                    }
                    else
                    {
                        pictureBox1.Image = null; // Fotoğraf bulunamazsa boş bırak
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Talimatlar yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
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
    }
}
