using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace yazlabProje1
{
    public partial class tarifmalzemeform : Form
    {
        private int selectedTarifId;

        public tarifmalzemeform(int tarifID)
        {
            InitializeComponent();
            selectedTarifId = tarifID; // Geçirilen TarifID'yi kaydediyoruz
        }

        private void tarifmalzeme_Load(object sender, EventArgs e)
        {
            LoadTarifler();
            LoadMalzemeler();
            comboBox1.SelectedValue = selectedTarifId; // Eklenen tarifi otomatik olarak seç
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void LoadMalzemeler()
        {
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";
            string query = "SELECT MalzemeID, MalzemeAdi FROM Tbl_Malzemeler ORDER BY MalzemeAdi";

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
                    comboBox2.DataSource = dataTable;
                    comboBox2.DisplayMember = "MalzemeAdi"; // Gösterilecek sütun
                    comboBox2.ValueMember = "MalzemeID"; // Değer olarak kullanılacak sütun
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ComboBox'lardan seçilen değerleri al
            int tarifID = (int)comboBox1.SelectedValue; // ComboBox1'den seçilen TarifID
            int malzemeID = (int)comboBox2.SelectedValue; // ComboBox2'den seçilen MalzemeID

            // TextBox'tan girilen miktarı al ve float'a çevir
            float malzemeMiktar;
            if (!float.TryParse(textBox1.Text, out malzemeMiktar))
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.");
                return; // Eğer geçersiz bir miktar girilmişse işlemi durdur
            }

            // Veritabanına ekleme işlemi
            string connectionString = "Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;";
            string query = "INSERT INTO Tbl_TarifMalzeme_iliskisi (TarifID, MalzemeID, MalzemeMiktar) VALUES (@TarifID, @MalzemeID, @MalzemeMiktar)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TarifID", tarifID);
                command.Parameters.AddWithValue("@MalzemeID", malzemeID);
                command.Parameters.AddWithValue("@MalzemeMiktar", malzemeMiktar);

                try
                {
                    connection.Open(); // Bağlantıyı aç
                    command.ExecuteNonQuery(); // Komutu çalıştır
                    MessageBox.Show("Veri başarıyla eklendi."); // Başarılı mesajı
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MalzemeForm form2 = new MalzemeForm();
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadMalzemeler();
        }
    }
}
