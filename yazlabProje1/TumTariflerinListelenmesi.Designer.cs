namespace yazlabProje1
{
    partial class TumTariflerinListelenmesi
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
            this.tblTariflerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazlab1_tarifDataSet12 = new yazlabProje1.yazlab1_tarifDataSet12();
            this.tbl_TariflerTableAdapter = new yazlabProje1.yazlab1_tarifDataSet12TableAdapters.Tbl_TariflerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.yazlab1_tarifDataSet13 = new yazlabProje1.yazlab1_tarifDataSet13();
            this.tblTariflerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TariflerTableAdapter1 = new yazlabProje1.yazlab1_tarifDataSet13TableAdapters.Tbl_TariflerTableAdapter();
            this.yazlab1_tarifDataSet14 = new yazlabProje1.yazlab1_tarifDataSet14();
            this.tblTariflerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.yazlab1_tarifDataSet15 = new yazlabProje1.yazlab1_tarifDataSet15();
            this.tbl_TariflerTableAdapter2 = new yazlabProje1.yazlab1_tarifDataSet15TableAdapters.Tbl_TariflerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarifIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazirlanmaSuresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTariflerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.yazlab1_tarifDataSet17 = new yazlabProje1.yazlab1_tarifDataSet17();
            this.yazlab1_tarifDataSet16 = new yazlabProje1.yazlab1_tarifDataSet16();
            this.tblTariflerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TariflerTableAdapter3 = new yazlabProje1.yazlab1_tarifDataSet16TableAdapters.Tbl_TariflerTableAdapter();
            this.tbl_TariflerTableAdapter4 = new yazlabProje1.yazlab1_tarifDataSet17TableAdapters.Tbl_TariflerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTariflerBindingSource
            // 
            this.tblTariflerBindingSource.DataMember = "Tbl_Tarifler";
            this.tblTariflerBindingSource.DataSource = this.yazlab1_tarifDataSet12;
            // 
            // yazlab1_tarifDataSet12
            // 
            this.yazlab1_tarifDataSet12.DataSetName = "yazlab1_tarifDataSet12";
            this.yazlab1_tarifDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_TariflerTableAdapter
            // 
            this.tbl_TariflerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Secilen Tarifin Fiyati:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(718, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secilen Tarifin Talimatlari:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(718, 330);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(197, 258);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // yazlab1_tarifDataSet13
            // 
            this.yazlab1_tarifDataSet13.DataSetName = "yazlab1_tarifDataSet13";
            this.yazlab1_tarifDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTariflerBindingSource1
            // 
            this.tblTariflerBindingSource1.DataMember = "Tbl_Tarifler";
            this.tblTariflerBindingSource1.DataSource = this.yazlab1_tarifDataSet13;
            // 
            // tbl_TariflerTableAdapter1
            // 
            this.tbl_TariflerTableAdapter1.ClearBeforeFill = true;
            // 
            // yazlab1_tarifDataSet14
            // 
            this.yazlab1_tarifDataSet14.DataSetName = "yazlab1_tarifDataSet14";
            this.yazlab1_tarifDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTariflerBindingSource2
            // 
            this.tblTariflerBindingSource2.DataMember = "Tbl_Tarifler";
            this.tblTariflerBindingSource2.DataSource = this.yazlab1_tarifDataSet15;
            // 
            // yazlab1_tarifDataSet15
            // 
            this.yazlab1_tarifDataSet15.DataSetName = "yazlab1_tarifDataSet15";
            this.yazlab1_tarifDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_TariflerTableAdapter2
            // 
            this.tbl_TariflerTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarifIDDataGridViewTextBoxColumn,
            this.tarifAdiDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.hazirlanmaSuresiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTariflerBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(1, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(693, 559);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tarifIDDataGridViewTextBoxColumn
            // 
            this.tarifIDDataGridViewTextBoxColumn.DataPropertyName = "TarifID";
            this.tarifIDDataGridViewTextBoxColumn.HeaderText = "TarifID";
            this.tarifIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarifIDDataGridViewTextBoxColumn.Name = "tarifIDDataGridViewTextBoxColumn";
            this.tarifIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarifIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tarifAdiDataGridViewTextBoxColumn
            // 
            this.tarifAdiDataGridViewTextBoxColumn.DataPropertyName = "TarifAdi";
            this.tarifAdiDataGridViewTextBoxColumn.HeaderText = "TarifAdi";
            this.tarifAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarifAdiDataGridViewTextBoxColumn.Name = "tarifAdiDataGridViewTextBoxColumn";
            this.tarifAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.Width = 75;
            // 
            // hazirlanmaSuresiDataGridViewTextBoxColumn
            // 
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.DataPropertyName = "HazirlanmaSuresi";
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.HeaderText = "HazirlanmaSuresi";
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.Name = "hazirlanmaSuresiDataGridViewTextBoxColumn";
            this.hazirlanmaSuresiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblTariflerBindingSource4
            // 
            this.tblTariflerBindingSource4.DataMember = "Tbl_Tarifler";
            this.tblTariflerBindingSource4.DataSource = this.yazlab1_tarifDataSet17;
            // 
            // yazlab1_tarifDataSet17
            // 
            this.yazlab1_tarifDataSet17.DataSetName = "yazlab1_tarifDataSet17";
            this.yazlab1_tarifDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazlab1_tarifDataSet16
            // 
            this.yazlab1_tarifDataSet16.DataSetName = "yazlab1_tarifDataSet16";
            this.yazlab1_tarifDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTariflerBindingSource3
            // 
            this.tblTariflerBindingSource3.DataMember = "Tbl_Tarifler";
            this.tblTariflerBindingSource3.DataSource = this.yazlab1_tarifDataSet16;
            // 
            // tbl_TariflerTableAdapter3
            // 
            this.tbl_TariflerTableAdapter3.ClearBeforeFill = true;
            // 
            // tbl_TariflerTableAdapter4
            // 
            this.tbl_TariflerTableAdapter4.ClearBeforeFill = true;
            // 
            // TumTariflerinListelenmesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "TumTariflerinListelenmesi";
            this.Text = "TumTariflerinListelenmesi";
            this.Load += new System.EventHandler(this.TumTariflerinListelenmesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private yazlab1_tarifDataSet12 yazlab1_tarifDataSet12;
        private System.Windows.Forms.BindingSource tblTariflerBindingSource;
        private yazlab1_tarifDataSet12TableAdapters.Tbl_TariflerTableAdapter tbl_TariflerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private yazlab1_tarifDataSet13 yazlab1_tarifDataSet13;
        private System.Windows.Forms.BindingSource tblTariflerBindingSource1;
        private yazlab1_tarifDataSet13TableAdapters.Tbl_TariflerTableAdapter tbl_TariflerTableAdapter1;
        private yazlab1_tarifDataSet14 yazlab1_tarifDataSet14;
        private yazlab1_tarifDataSet15 yazlab1_tarifDataSet15;
        private System.Windows.Forms.BindingSource tblTariflerBindingSource2;
        private yazlab1_tarifDataSet15TableAdapters.Tbl_TariflerTableAdapter tbl_TariflerTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yazlab1_tarifDataSet16 yazlab1_tarifDataSet16;
        private System.Windows.Forms.BindingSource tblTariflerBindingSource3;
        private yazlab1_tarifDataSet16TableAdapters.Tbl_TariflerTableAdapter tbl_TariflerTableAdapter3;
        private yazlab1_tarifDataSet17 yazlab1_tarifDataSet17;
        private System.Windows.Forms.BindingSource tblTariflerBindingSource4;
        private yazlab1_tarifDataSet17TableAdapters.Tbl_TariflerTableAdapter tbl_TariflerTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazirlanmaSuresiDataGridViewTextBoxColumn;
    }
}