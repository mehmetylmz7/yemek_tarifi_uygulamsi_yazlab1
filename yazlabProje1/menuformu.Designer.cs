namespace yazlabProje1
{
    partial class menuformu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tarifeklebutonu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarifAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazirlanmaSuresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talimatlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTariflerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazlab1_tarifDataSet2 = new yazlabProje1.yazlab1_tarifDataSet2();
            this.tbl_TariflerTableAdapter = new yazlabProje1.yazlab1_tarifDataSet2TableAdapters.Tbl_TariflerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tarifeklebutonu
            // 
            this.tarifeklebutonu.Location = new System.Drawing.Point(55, 24);
            this.tarifeklebutonu.Name = "tarifeklebutonu";
            this.tarifeklebutonu.Size = new System.Drawing.Size(125, 70);
            this.tarifeklebutonu.TabIndex = 0;
            this.tarifeklebutonu.Text = "Tarif Ekle";
            this.tarifeklebutonu.UseVisualStyleBackColor = true;
            this.tarifeklebutonu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tarif Guncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(529, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tarif Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarifAdiDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.hazirlanmaSuresiDataGridViewTextBoxColumn,
            this.talimatlarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTariflerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 253);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tarifAdiDataGridViewTextBoxColumn
            // 
            this.tarifAdiDataGridViewTextBoxColumn.DataPropertyName = "TarifAdi";
            this.tarifAdiDataGridViewTextBoxColumn.FillWeight = 50F;
            this.tarifAdiDataGridViewTextBoxColumn.HeaderText = "TarifAdi";
            this.tarifAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarifAdiDataGridViewTextBoxColumn.Name = "tarifAdiDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.FillWeight = 50F;
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // hazirlanmaSuresiDataGridViewTextBoxColumn
            // 
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.DataPropertyName = "HazirlanmaSuresi";
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.FillWeight = 30F;
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.HeaderText = "HazirlanmaSuresi";
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.Name = "hazirlanmaSuresiDataGridViewTextBoxColumn";
            // 
            // talimatlarDataGridViewTextBoxColumn
            // 
            this.talimatlarDataGridViewTextBoxColumn.DataPropertyName = "Talimatlar";
            this.talimatlarDataGridViewTextBoxColumn.HeaderText = "Talimatlar";
            this.talimatlarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.talimatlarDataGridViewTextBoxColumn.Name = "talimatlarDataGridViewTextBoxColumn";
            // 
            // tblTariflerBindingSource
            // 
            this.tblTariflerBindingSource.DataMember = "Tbl_Tarifler";
            this.tblTariflerBindingSource.DataSource = this.yazlab1_tarifDataSet2;
            // 
            // yazlab1_tarifDataSet2
            // 
            this.yazlab1_tarifDataSet2.DataSetName = "yazlab1_tarifDataSet2";
            this.yazlab1_tarifDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_TariflerTableAdapter
            // 
            this.tbl_TariflerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hazirlanma Suresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Talimatlar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ana yemek",
            "Corba",
            "Tatli",
            "Icecek",
            "Pilav"});
            this.comboBox1.Location = new System.Drawing.Point(323, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(323, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(861, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(417, 22);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(861, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 22);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(861, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(96, 22);
            this.textBox6.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ana yemek",
            "Corba",
            "Tatli",
            "Icecek",
            "Pilav"});
            this.comboBox2.Location = new System.Drawing.Point(861, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Talimatlar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(706, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hazirlanma Suresi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(706, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ad:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(90, 193);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // menuformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 559);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tarifeklebutonu);
            this.Name = "menuformu";
            this.Text = "menuformu";
            this.Load += new System.EventHandler(this.menuformu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tarifeklebutonu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yazlab1_tarifDataSet2 yazlab1_tarifDataSet2;
        private System.Windows.Forms.BindingSource tblTariflerBindingSource;
        private yazlab1_tarifDataSet2TableAdapters.Tbl_TariflerTableAdapter tbl_TariflerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazirlanmaSuresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talimatlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
    }
}