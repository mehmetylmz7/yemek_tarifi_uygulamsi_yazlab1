using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace yazlabProje1
{
    public partial class Tarifonerisi : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;"); // Update connection string if needed

        public Tarifonerisi()
        {
            InitializeComponent();
            MalzemeleriYukle();
        }

        private void Tarifonerisi_Load(object sender, EventArgs e)
        {
            // Add event handlers for combo box selection changes
            comboBox1.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += comboBox_SelectedIndexChanged;
        }

        private void MalzemeleriYukle()
        {
            try
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("SELECT DISTINCT MalzemeAdi FROM Tbl_Malzemeler", conn);
                SqlDataReader dr = komut.ExecuteReader();

                // ComboBox'ları temizle ve malzemeleri ekle
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();

                while (dr.Read())
                {
                    string malzemeAdi = dr["MalzemeAdi"].ToString();
                    comboBox1.Items.Add(malzemeAdi);
                    comboBox2.Items.Add(malzemeAdi);
                    comboBox3.Items.Add(malzemeAdi);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreliTarifleriGoster();
        }

        private void FiltreliTarifleriGoster()
        {
            // ComboBox'tan seçilen malzeme ID'lerini alalım
            List<int?> malzemeIds = new List<int?>
    {
        GetMalzemeId(comboBox1.SelectedItem?.ToString()),
        GetMalzemeId(comboBox2.SelectedItem?.ToString()),
        GetMalzemeId(comboBox3.SelectedItem?.ToString())
    };

            // Seçilen malzemelerden null olanları filtreleyelim
            var seciliMalzemeler = malzemeIds.Where(id => id.HasValue).ToList();

            if (seciliMalzemeler.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir malzeme seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tariflerde seçilen malzemeler hariç kullanılan diğer malzemelerin maliyetini bulacağız
            string query = $@"
    SELECT T.TarifID, T.TarifAdi, T.Kategori, T.HazirlanmaSuresi,
           COUNT(DISTINCT TM.MalzemeID) * 100.0 / {seciliMalzemeler.Count} AS EslesmeYuzdesi,
           (SELECT SUM(M2.BirimFiyat * TM2.MalzemeMiktar)
            FROM Tbl_Malzemeler M2
            INNER JOIN Tbl_TarifMalzeme_iliskisi TM2 ON M2.MalzemeID = TM2.MalzemeID
            WHERE TM2.TarifID = T.TarifID
            AND M2.MalzemeID NOT IN ({string.Join(",", seciliMalzemeler.Select((_, i) => $"@MalzemeId{i}"))})
           ) AS ToplamKullanilmayanMaliyet
    FROM Tbl_Tarifler T
    INNER JOIN Tbl_TarifMalzeme_iliskisi TM ON T.TarifID = TM.TarifID
    INNER JOIN Tbl_Malzemeler M ON TM.MalzemeID = M.MalzemeID
    WHERE TM.MalzemeID IN ({string.Join(",", seciliMalzemeler.Select((_, i) => $"@MalzemeId{i}"))})
    GROUP BY T.TarifID, T.TarifAdi, T.Kategori, T.HazirlanmaSuresi
    HAVING COUNT(DISTINCT TM.MalzemeID) > 0
    ORDER BY EslesmeYuzdesi DESC";

            try
            {
                conn.Open();

                // SQL komutunu çalıştırıyoruz
                SqlCommand komut = new SqlCommand(query, conn);
                for (int i = 0; i < seciliMalzemeler.Count; i++)
                {
                    komut.Parameters.AddWithValue($"@MalzemeId{i}", seciliMalzemeler[i].Value);
                }

                SqlDataAdapter adtr = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adtr.Fill(dt);

                // Sonuçları DataGridView'de göster
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = dt;
                    RenklendirTarifler();
                }
                else
                {
                    MessageBox.Show("Tarifeleri görüntülemek için bir DataGridView kontrolü ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }



        private int? GetMalzemeId(string malzemeAdi)
        {
            if (string.IsNullOrEmpty(malzemeAdi)) return null;

            string query = "SELECT MalzemeID FROM Tbl_Malzemeler WHERE MalzemeAdi = @MalzemeAdi";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                var result = cmd.ExecuteScalar();
                return result != null ? (int?)Convert.ToInt32(result) : null;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        private void RenklendirTarifler()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["EslesmeYuzdesi"].Value != null)
                {
                    double yuzde = Convert.ToDouble(row.Cells["EslesmeYuzdesi"].Value);
                    if (yuzde == 100)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;  // Malzemeler tam
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;  // Eksik malzeme var
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}