﻿namespace yazlabProje1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tarifgoruntulebutonu = new System.Windows.Forms.Button();
            this.menubutonu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tarifgoruntulebutonu
            // 
            this.tarifgoruntulebutonu.Location = new System.Drawing.Point(184, 166);
            this.tarifgoruntulebutonu.Name = "tarifgoruntulebutonu";
            this.tarifgoruntulebutonu.Size = new System.Drawing.Size(276, 192);
            this.tarifgoruntulebutonu.TabIndex = 0;
            this.tarifgoruntulebutonu.Text = "Tarifleri Goruntule";
            this.tarifgoruntulebutonu.UseVisualStyleBackColor = true;
            this.tarifgoruntulebutonu.Click += new System.EventHandler(this.tarifgoruntulebutonu_Click);
            // 
            // menubutonu
            // 
            this.menubutonu.Location = new System.Drawing.Point(550, 166);
            this.menubutonu.Name = "menubutonu";
            this.menubutonu.Size = new System.Drawing.Size(276, 192);
            this.menubutonu.TabIndex = 1;
            this.menubutonu.Text = "Menu(tarif ekleme , guncelleme, silme)";
            this.menubutonu.UseVisualStyleBackColor = true;
            this.menubutonu.Click += new System.EventHandler(this.menubutonu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 192);
            this.button1.TabIndex = 2;
            this.button1.Text = "Malzeme Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 155);
            this.button2.TabIndex = 3;
            this.button2.Text = "tarif  malzeme iliskisi kurma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 725);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menubutonu);
            this.Controls.Add(this.tarifgoruntulebutonu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tarifgoruntulebutonu;
        private System.Windows.Forms.Button menubutonu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
