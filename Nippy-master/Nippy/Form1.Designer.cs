namespace Nippy
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_ogrenciSoyadi = new System.Windows.Forms.TextBox();
            this.txt_ogrenciAdi = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chk_aidat = new System.Windows.Forms.CheckBox();
            this.lbl_devamsizlik = new System.Windows.Forms.Label();
            this.btn_detay = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_devamsizlik = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyad_update = new System.Windows.Forms.TextBox();
            this.txt_ad_update = new System.Windows.Forms.TextBox();
            this.txt_no_update = new System.Windows.Forms.TextBox();
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_detay_ekle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_veliadi = new System.Windows.Forms.TextBox();
            this.lbl_detay_ogrenciad = new System.Windows.Forms.Label();
            this.cmb_ogrenciNo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SpringGreen;
            this.tabPage1.Controls.Add(this.btn_ekle);
            this.tabPage1.Controls.Add(this.txt_ogrenciSoyadi);
            this.tabPage1.Controls.Add(this.txt_ogrenciAdi);
            this.tabPage1.Controls.Add(this.txt_no);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci Kayıt";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(286, 244);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(265, 60);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "Öğrenciyi Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_ogrenciSoyadi
            // 
            this.txt_ogrenciSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogrenciSoyadi.Location = new System.Drawing.Point(308, 187);
            this.txt_ogrenciSoyadi.Name = "txt_ogrenciSoyadi";
            this.txt_ogrenciSoyadi.Size = new System.Drawing.Size(210, 36);
            this.txt_ogrenciSoyadi.TabIndex = 5;
            // 
            // txt_ogrenciAdi
            // 
            this.txt_ogrenciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogrenciAdi.Location = new System.Drawing.Point(308, 132);
            this.txt_ogrenciAdi.Name = "txt_ogrenciAdi";
            this.txt_ogrenciAdi.Size = new System.Drawing.Size(210, 36);
            this.txt_ogrenciAdi.TabIndex = 4;
            // 
            // txt_no
            // 
            this.txt_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_no.Location = new System.Drawing.Point(308, 74);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(210, 36);
            this.txt_no.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(101, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chk_aidat);
            this.tabPage2.Controls.Add(this.lbl_devamsizlik);
            this.tabPage2.Controls.Add(this.btn_detay);
            this.tabPage2.Controls.Add(this.btn_sil);
            this.tabPage2.Controls.Add(this.btn_guncelle);
            this.tabPage2.Controls.Add(this.btn_devamsizlik);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_soyad_update);
            this.tabPage2.Controls.Add(this.txt_ad_update);
            this.tabPage2.Controls.Add(this.txt_no_update);
            this.tabPage2.Controls.Add(this.lst_liste);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Öğrenci Listele";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chk_aidat
            // 
            this.chk_aidat.AutoSize = true;
            this.chk_aidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_aidat.Location = new System.Drawing.Point(263, 179);
            this.chk_aidat.Name = "chk_aidat";
            this.chk_aidat.Size = new System.Drawing.Size(84, 30);
            this.chk_aidat.TabIndex = 12;
            this.chk_aidat.Text = "Aidat";
            this.chk_aidat.UseVisualStyleBackColor = true;
            // 
            // lbl_devamsizlik
            // 
            this.lbl_devamsizlik.AutoSize = true;
            this.lbl_devamsizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_devamsizlik.Location = new System.Drawing.Point(189, 181);
            this.lbl_devamsizlik.Name = "lbl_devamsizlik";
            this.lbl_devamsizlik.Size = new System.Drawing.Size(27, 29);
            this.lbl_devamsizlik.TabIndex = 11;
            this.lbl_devamsizlik.Text = "0";
            // 
            // btn_detay
            // 
            this.btn_detay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_detay.Location = new System.Drawing.Point(333, 262);
            this.btn_detay.Name = "btn_detay";
            this.btn_detay.Size = new System.Drawing.Size(111, 48);
            this.btn_detay.TabIndex = 10;
            this.btn_detay.Text = "Detay";
            this.btn_detay.UseVisualStyleBackColor = true;
            this.btn_detay.Click += new System.EventHandler(this.btn_detay_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(235, 262);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(92, 48);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(18, 262);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(211, 48);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_devamsizlik
            // 
            this.btn_devamsizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_devamsizlik.Location = new System.Drawing.Point(18, 181);
            this.btn_devamsizlik.Name = "btn_devamsizlik";
            this.btn_devamsizlik.Size = new System.Drawing.Size(123, 29);
            this.btn_devamsizlik.TabIndex = 7;
            this.btn_devamsizlik.Text = "Devamsızlık";
            this.btn_devamsizlik.UseVisualStyleBackColor = true;
            this.btn_devamsizlik.Click += new System.EventHandler(this.btn_devamsizlik_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Öğrenci Soyadı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Öğrenci Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Öğrenci No :";
            // 
            // txt_soyad_update
            // 
            this.txt_soyad_update.Location = new System.Drawing.Point(169, 130);
            this.txt_soyad_update.Name = "txt_soyad_update";
            this.txt_soyad_update.Size = new System.Drawing.Size(100, 22);
            this.txt_soyad_update.TabIndex = 3;
            // 
            // txt_ad_update
            // 
            this.txt_ad_update.Location = new System.Drawing.Point(169, 74);
            this.txt_ad_update.Name = "txt_ad_update";
            this.txt_ad_update.Size = new System.Drawing.Size(100, 22);
            this.txt_ad_update.TabIndex = 2;
            // 
            // txt_no_update
            // 
            this.txt_no_update.Location = new System.Drawing.Point(169, 19);
            this.txt_no_update.Name = "txt_no_update";
            this.txt_no_update.Size = new System.Drawing.Size(100, 22);
            this.txt_no_update.TabIndex = 1;
            // 
            // lst_liste
            // 
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.ItemHeight = 16;
            this.lst_liste.Location = new System.Drawing.Point(521, 3);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.Size = new System.Drawing.Size(240, 388);
            this.lst_liste.TabIndex = 0;
            this.lst_liste.SelectedIndexChanged += new System.EventHandler(this.lst_liste_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_detay_ekle);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_telefon);
            this.tabPage3.Controls.Add(this.txt_adres);
            this.tabPage3.Controls.Add(this.txt_veliadi);
            this.tabPage3.Controls.Add(this.lbl_detay_ogrenciad);
            this.tabPage3.Controls.Add(this.cmb_ogrenciNo);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Öğrenci Detay";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_detay_ekle
            // 
            this.btn_detay_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_detay_ekle.Location = new System.Drawing.Point(232, 336);
            this.btn_detay_ekle.Name = "btn_detay_ekle";
            this.btn_detay_ekle.Size = new System.Drawing.Size(303, 48);
            this.btn_detay_ekle.TabIndex = 9;
            this.btn_detay_ekle.Text = "Kayıtı Ekle";
            this.btn_detay_ekle.UseVisualStyleBackColor = true;
            this.btn_detay_ekle.Click += new System.EventHandler(this.btn_detay_ekle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(282, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Öğrenci Numarası Seçiniz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(78, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Telefonu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(104, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Adresi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(75, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Veli İsmi :";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telefon.Location = new System.Drawing.Point(232, 293);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(303, 36);
            this.txt_telefon.TabIndex = 4;
            // 
            // txt_adres
            // 
            this.txt_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.Location = new System.Drawing.Point(232, 241);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(303, 36);
            this.txt_adres.TabIndex = 3;
            // 
            // txt_veliadi
            // 
            this.txt_veliadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_veliadi.Location = new System.Drawing.Point(232, 189);
            this.txt_veliadi.Name = "txt_veliadi";
            this.txt_veliadi.Size = new System.Drawing.Size(303, 36);
            this.txt_veliadi.TabIndex = 2;
            // 
            // lbl_detay_ogrenciad
            // 
            this.lbl_detay_ogrenciad.AutoSize = true;
            this.lbl_detay_ogrenciad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_detay_ogrenciad.Location = new System.Drawing.Point(316, 127);
            this.lbl_detay_ogrenciad.Name = "lbl_detay_ogrenciad";
            this.lbl_detay_ogrenciad.Size = new System.Drawing.Size(143, 29);
            this.lbl_detay_ogrenciad.TabIndex = 1;
            this.lbl_detay_ogrenciad.Text = "AD-SOYAD";
            // 
            // cmb_ogrenciNo
            // 
            this.cmb_ogrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ogrenciNo.FormattingEnabled = true;
            this.cmb_ogrenciNo.Location = new System.Drawing.Point(232, 54);
            this.cmb_ogrenciNo.Name = "cmb_ogrenciNo";
            this.cmb_ogrenciNo.Size = new System.Drawing.Size(303, 37);
            this.cmb_ogrenciNo.TabIndex = 0;
            this.cmb_ogrenciNo.SelectedIndexChanged += new System.EventHandler(this.cmb_ogrenciNo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Nippy Öğrenci Bilgi Sistemi v1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_ogrenciSoyadi;
        private System.Windows.Forms.TextBox txt_ogrenciAdi;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Label lbl_devamsizlik;
        private System.Windows.Forms.Button btn_detay;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_devamsizlik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soyad_update;
        private System.Windows.Forms.TextBox txt_ad_update;
        private System.Windows.Forms.TextBox txt_no_update;
        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.CheckBox chk_aidat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_veliadi;
        private System.Windows.Forms.Label lbl_detay_ogrenciad;
        private System.Windows.Forms.ComboBox cmb_ogrenciNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_detay_ekle;
    }
}

