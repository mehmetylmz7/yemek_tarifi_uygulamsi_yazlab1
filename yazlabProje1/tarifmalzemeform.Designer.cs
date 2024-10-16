namespace yazlabProje1
{
    partial class tarifmalzemeform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblTariflerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazlab1_tarifDataSet5 = new yazlabProje1.yazlab1_tarifDataSet5();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tblMalzemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazlab1_tarifDataSet6 = new yazlabProje1.yazlab1_tarifDataSet6();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbl_TariflerTableAdapter = new yazlabProje1.yazlab1_tarifDataSet5TableAdapters.Tbl_TariflerTableAdapter();
            this.tbl_MalzemelerTableAdapter = new yazlabProje1.yazlab1_tarifDataSet6TableAdapters.Tbl_MalzemelerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Malzeme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miktar";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblTariflerBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tblTariflerBindingSource
            // 
            this.tblTariflerBindingSource.DataMember = "Tbl_Tarifler";
            this.tblTariflerBindingSource.DataSource = this.yazlab1_tarifDataSet5;
            // 
            // yazlab1_tarifDataSet5
            // 
            this.yazlab1_tarifDataSet5.DataSetName = "yazlab1_tarifDataSet5";
            this.yazlab1_tarifDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tblMalzemelerBindingSource;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(174, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // tblMalzemelerBindingSource
            // 
            this.tblMalzemelerBindingSource.DataMember = "Tbl_Malzemeler";
            this.tblMalzemelerBindingSource.DataSource = this.yazlab1_tarifDataSet6;
            // 
            // yazlab1_tarifDataSet6
            // 
            this.yazlab1_tarifDataSet6.DataSetName = "yazlab1_tarifDataSet6";
            this.yazlab1_tarifDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 5;
            // 
            // tbl_TariflerTableAdapter
            // 
            this.tbl_TariflerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_MalzemelerTableAdapter
            // 
            this.tbl_MalzemelerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Malzeme yok ise asagidan ekleyiniz";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Malzeme ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tarifmalzemeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tarifmalzemeform";
            this.Text = "Malzeme yok ise asagidan ekleyiniz";
            this.Load += new System.EventHandler(this.tarifmalzeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTariflerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazlab1_tarifDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private yazlab1_tarifDataSet5 yazlab1_tarifDataSet5;
        private System.Windows.Forms.BindingSource tblTariflerBindingSource;
        private yazlab1_tarifDataSet5TableAdapters.Tbl_TariflerTableAdapter tbl_TariflerTableAdapter;
        private yazlab1_tarifDataSet6 yazlab1_tarifDataSet6;
        private System.Windows.Forms.BindingSource tblMalzemelerBindingSource;
        private yazlab1_tarifDataSet6TableAdapters.Tbl_MalzemelerTableAdapter tbl_MalzemelerTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}