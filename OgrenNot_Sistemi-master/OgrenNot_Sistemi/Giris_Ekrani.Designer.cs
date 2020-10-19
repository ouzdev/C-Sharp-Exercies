namespace OgrenNot_Sistemi
{
    partial class Giris_Ekrani
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
            this.msk_ogrenci_numara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_ogrenci_numara
            // 
            this.msk_ogrenci_numara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msk_ogrenci_numara.Location = new System.Drawing.Point(163, 135);
            this.msk_ogrenci_numara.Mask = "0000";
            this.msk_ogrenci_numara.Name = "msk_ogrenci_numara";
            this.msk_ogrenci_numara.Size = new System.Drawing.Size(65, 36);
            this.msk_ogrenci_numara.TabIndex = 0;
            this.msk_ogrenci_numara.ValidatingType = typeof(int);
            this.msk_ogrenci_numara.TextChanged += new System.EventHandler(this.msk_ogrenci_numara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Numaranızı Giriniz.";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(118, 177);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(148, 37);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Sisteme Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Giris_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(387, 381);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_ogrenci_numara);
            this.Name = "Giris_Ekrani";
            this.Text = "OgrenNot Giriş Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_ogrenci_numara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_giris;
    }
}

