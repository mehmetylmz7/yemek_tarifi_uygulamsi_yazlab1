namespace yazlabProje1
{
    partial class MalzemeForm
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tarifeklebutonu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeBirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMalzemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazlab1_tarifDataSet3 = new yazlabProje1.yazlab1_tarifDataSet3();
            this.tbl_MalzemelerTableAdapter = new yazlabProje1.yazlab1_tarifDataSet3TableAdapters.Tbl_MalzemelerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(428, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 22);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(428, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 22);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 22);
            this.textBox1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "litre",
            "kilogram",
            "tane"});
            this.comboBox1.Location = new System.Drawing.Point(428, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Birim fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Malzeme toplam miktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Malzeme birim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad:";
            // 
            // tarifeklebutonu
            // 
            this.tarifeklebutonu.Location = new System.Drawing.Point(122, 27);
            this.tarifeklebutonu.Name = "tarifeklebutonu";
            this.tarifeklebutonu.Size = new System.Drawing.Size(125, 70);
            this.tarifeklebutonu.TabIndex = 12;
            this.tarifeklebutonu.Text = "Malzeme ekle";
            this.tarifeklebutonu.UseVisualStyleBackColor = true;
            this.tarifeklebutonu.Click += new System.EventHandler(this.tarifeklebutonu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.toplamMiktarDataGridViewTextBoxColumn,
            this.malzemeBirimDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMalzemelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 363);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            this.malzemeAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamMiktarDataGridViewTextBoxColumn
            // 
            this.toplamMiktarDataGridViewTextBoxColumn.DataPropertyName = "ToplamMiktar";
            this.toplamMiktarDataGridViewTextBoxColumn.HeaderText = "ToplamMiktar";
            this.toplamMiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamMiktarDataGridViewTextBoxColumn.Name = "toplamMiktarDataGridViewTextBoxColumn";
            this.toplamMiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // malzemeBirimDataGridViewTextBoxColumn
            // 
            this.malzemeBirimDataGridViewTextBoxColumn.DataPropertyName = "MalzemeBirim";
            this.malzemeBirimDataGridViewTextBoxColumn.HeaderText = "MalzemeBirim";
            this.malzemeBirimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.malzemeBirimDataGridViewTextBoxColumn.Name = "malzemeBirimDataGridViewTextBoxColumn";
            this.malzemeBirimDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            this.birimFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblMalzemelerBindingSource
            // 
            this.tblMalzemelerBindingSource.DataMember = "Tbl_Malzemeler";
            this.tblMalzemelerBindingSource.DataSource = this.yazlab1_tarifDataSet3;
            // 
            // yazlab1_tarifDataSet3
            // 
            this.yazlab1_tarifDataSet3.DataSetName = "yazlab1_tarifDataSet3";
            this.yazlab1_tarifDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MalzemelerTableAdapter
            // 
            this.tbl_MalzemelerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 54);
            this.button1.TabIndex = 22;
            this.button1.Text = "secenekleri temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MalzemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarifeklebutonu);
            this.Name = "MalzemeForm";
            this.Text = "MalzemeForm";
            this.Load += new System.EventHandler(this.MalzemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tarifeklebutonu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yazlab1_tarifDataSet3 yazlab1_tarifDataSet3;
        private System.Windows.Forms.BindingSource tblMalzemelerBindingSource;
        private yazlab1_tarifDataSet3TableAdapters.Tbl_MalzemelerTableAdapter tbl_MalzemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeBirimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}