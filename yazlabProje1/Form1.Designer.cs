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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 725);
            this.Controls.Add(this.menubutonu);
            this.Controls.Add(this.tarifgoruntulebutonu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tarifgoruntulebutonu;
        private System.Windows.Forms.Button menubutonu;
    }
}

