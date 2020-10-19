namespace Nippy
{
    partial class Detay_Formu
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
            this.lbl_ogrenci_ad_soyad = new System.Windows.Forms.Label();
            this.lbl_veli_ad_soyad = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ogrenci_ad_soyad
            // 
            this.lbl_ogrenci_ad_soyad.AutoSize = true;
            this.lbl_ogrenci_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrenci_ad_soyad.Location = new System.Drawing.Point(280, 30);
            this.lbl_ogrenci_ad_soyad.Name = "lbl_ogrenci_ad_soyad";
            this.lbl_ogrenci_ad_soyad.Size = new System.Drawing.Size(0, 25);
            this.lbl_ogrenci_ad_soyad.TabIndex = 0;
            // 
            // lbl_veli_ad_soyad
            // 
            this.lbl_veli_ad_soyad.AutoSize = true;
            this.lbl_veli_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_veli_ad_soyad.Location = new System.Drawing.Point(280, 80);
            this.lbl_veli_ad_soyad.Name = "lbl_veli_ad_soyad";
            this.lbl_veli_ad_soyad.Size = new System.Drawing.Size(0, 25);
            this.lbl_veli_ad_soyad.TabIndex = 1;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(280, 130);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(0, 25);
            this.lbl_adres.TabIndex = 2;
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon.Location = new System.Drawing.Point(280, 180);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(0, 25);
            this.lbl_telefon.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(144, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefonu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(165, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adresi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Veli Adı ve Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Öğrenci Adı ve Soyadı :";
            // 
            // Detay_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 260);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_adres);
            this.Controls.Add(this.lbl_veli_ad_soyad);
            this.Controls.Add(this.lbl_ogrenci_ad_soyad);
            this.Name = "Detay_Formu";
            this.Text = "Nippy Detay Sayfası ";
            this.Load += new System.EventHandler(this.Detay_Formu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ogrenci_ad_soyad;
        private System.Windows.Forms.Label lbl_veli_ad_soyad;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}