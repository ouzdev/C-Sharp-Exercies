namespace Maselty_Ticket
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_boskoltuk = new System.Windows.Forms.Button();
            this.btn_hasilat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_indirimli = new System.Windows.Forms.CheckBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_satis = new System.Windows.Forms.Button();
            this.cmb_filmsec = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_mevcut_salon = new System.Windows.Forms.CheckBox();
            this.cmb_salonsec = new System.Windows.Forms.ComboBox();
            this.txt_koltukSayisi = new System.Windows.Forms.TextBox();
            this.txt_filmIsmi = new System.Windows.Forms.TextBox();
            this.txt_SalonIsmi = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cmb_filmsec);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bilet Satış";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Film İsmi :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_boskoltuk);
            this.groupBox2.Controls.Add(this.btn_hasilat);
            this.groupBox2.Location = new System.Drawing.Point(254, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // btn_boskoltuk
            // 
            this.btn_boskoltuk.Location = new System.Drawing.Point(123, 87);
            this.btn_boskoltuk.Name = "btn_boskoltuk";
            this.btn_boskoltuk.Size = new System.Drawing.Size(111, 56);
            this.btn_boskoltuk.TabIndex = 1;
            this.btn_boskoltuk.Text = "BOŞ KOLTUK";
            this.btn_boskoltuk.UseVisualStyleBackColor = true;
            this.btn_boskoltuk.Click += new System.EventHandler(this.btn_boskoltuk_Click);
            // 
            // btn_hasilat
            // 
            this.btn_hasilat.Location = new System.Drawing.Point(6, 87);
            this.btn_hasilat.Name = "btn_hasilat";
            this.btn_hasilat.Size = new System.Drawing.Size(111, 56);
            this.btn_hasilat.TabIndex = 0;
            this.btn_hasilat.Text = "HASILAT";
            this.btn_hasilat.UseVisualStyleBackColor = true;
            this.btn_hasilat.Click += new System.EventHandler(this.btn_hasilat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_indirimli);
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.btn_satis);
            this.groupBox1.Location = new System.Drawing.Point(16, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış / Satış İptal";
            // 
            // chk_indirimli
            // 
            this.chk_indirimli.AutoSize = true;
            this.chk_indirimli.Location = new System.Drawing.Point(16, 39);
            this.chk_indirimli.Name = "chk_indirimli";
            this.chk_indirimli.Size = new System.Drawing.Size(112, 21);
            this.chk_indirimli.TabIndex = 4;
            this.chk_indirimli.Text = "İndirimli Satış";
            this.chk_indirimli.UseVisualStyleBackColor = true;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(84, 87);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(111, 56);
            this.btn_iptal.TabIndex = 3;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = true;
            // 
            // btn_satis
            // 
            this.btn_satis.Location = new System.Drawing.Point(6, 87);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(76, 56);
            this.btn_satis.TabIndex = 2;
            this.btn_satis.Text = "SATIŞ";
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // cmb_filmsec
            // 
            this.cmb_filmsec.FormattingEnabled = true;
            this.cmb_filmsec.Location = new System.Drawing.Point(104, 31);
            this.cmb_filmsec.Name = "cmb_filmsec";
            this.cmb_filmsec.Size = new System.Drawing.Size(121, 24);
            this.cmb_filmsec.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_olustur);
            this.tabPage2.Controls.Add(this.btn_degistir);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.chk_mevcut_salon);
            this.tabPage2.Controls.Add(this.cmb_salonsec);
            this.tabPage2.Controls.Add(this.txt_koltukSayisi);
            this.tabPage2.Controls.Add(this.txt_filmIsmi);
            this.tabPage2.Controls.Add(this.txt_SalonIsmi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Düzenleme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_olustur
            // 
            this.btn_olustur.Location = new System.Drawing.Point(193, 251);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(86, 34);
            this.btn_olustur.TabIndex = 10;
            this.btn_olustur.Text = "Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // btn_degistir
            // 
            this.btn_degistir.Location = new System.Drawing.Point(98, 251);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(89, 34);
            this.btn_degistir.TabIndex = 9;
            this.btn_degistir.Text = "Değiştir";
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Koltuk Sayısı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Film İsmi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salon İsmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salon İsmi :";
            // 
            // chk_mevcut_salon
            // 
            this.chk_mevcut_salon.AutoSize = true;
            this.chk_mevcut_salon.Location = new System.Drawing.Point(151, 70);
            this.chk_mevcut_salon.Name = "chk_mevcut_salon";
            this.chk_mevcut_salon.Size = new System.Drawing.Size(115, 21);
            this.chk_mevcut_salon.TabIndex = 4;
            this.chk_mevcut_salon.Text = "Mevcut Salon";
            this.chk_mevcut_salon.UseVisualStyleBackColor = true;
            this.chk_mevcut_salon.CheckedChanged += new System.EventHandler(this.chk_mevcut_salon_CheckedChanged);
            // 
            // cmb_salonsec
            // 
            this.cmb_salonsec.FormattingEnabled = true;
            this.cmb_salonsec.Location = new System.Drawing.Point(128, 103);
            this.cmb_salonsec.Name = "cmb_salonsec";
            this.cmb_salonsec.Size = new System.Drawing.Size(121, 24);
            this.cmb_salonsec.TabIndex = 3;
            this.cmb_salonsec.SelectedIndexChanged += new System.EventHandler(this.cmb_salonsec_SelectedIndexChanged);
            // 
            // txt_koltukSayisi
            // 
            this.txt_koltukSayisi.Location = new System.Drawing.Point(128, 194);
            this.txt_koltukSayisi.Name = "txt_koltukSayisi";
            this.txt_koltukSayisi.Size = new System.Drawing.Size(121, 22);
            this.txt_koltukSayisi.TabIndex = 2;
            // 
            // txt_filmIsmi
            // 
            this.txt_filmIsmi.Location = new System.Drawing.Point(128, 155);
            this.txt_filmIsmi.Name = "txt_filmIsmi";
            this.txt_filmIsmi.Size = new System.Drawing.Size(121, 22);
            this.txt_filmIsmi.TabIndex = 1;
            // 
            // txt_SalonIsmi
            // 
            this.txt_SalonIsmi.Location = new System.Drawing.Point(128, 27);
            this.txt_SalonIsmi.Name = "txt_SalonIsmi";
            this.txt_SalonIsmi.Size = new System.Drawing.Size(121, 22);
            this.txt_SalonIsmi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_boskoltuk;
        private System.Windows.Forms.Button btn_hasilat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.ComboBox cmb_filmsec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_mevcut_salon;
        private System.Windows.Forms.ComboBox cmb_salonsec;
        private System.Windows.Forms.TextBox txt_koltukSayisi;
        private System.Windows.Forms.TextBox txt_filmIsmi;
        private System.Windows.Forms.TextBox txt_SalonIsmi;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.CheckBox chk_indirimli;
    }
}

