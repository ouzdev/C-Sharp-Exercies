namespace BellWood_Hotel_Otomasyon
{
    partial class Musteriler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_musteri_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_musteri_sil = new System.Windows.Forms.Button();
            this.btn_musteri_ara = new System.Windows.Forms.Button();
            this.btn_musteri_guncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_oda_no = new System.Windows.Forms.TextBox();
            this.msk_tel_no = new System.Windows.Forms.MaskedTextBox();
            this.msk_tc_no = new System.Windows.Forms.MaskedTextBox();
            this.txt_musteri_soyadi = new System.Windows.Forms.TextBox();
            this.txt_musteri_adi = new System.Windows.Forms.TextBox();
            this.dtp_cikis_tarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_giris_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_musteri_ara = new System.Windows.Forms.TextBox();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 305);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1549, 316);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // btn_musteri_listele
            // 
            this.btn_musteri_listele.Location = new System.Drawing.Point(6, 21);
            this.btn_musteri_listele.Name = "btn_musteri_listele";
            this.btn_musteri_listele.Size = new System.Drawing.Size(203, 61);
            this.btn_musteri_listele.TabIndex = 1;
            this.btn_musteri_listele.Text = "Müşterileri Listele";
            this.btn_musteri_listele.UseVisualStyleBackColor = true;
            this.btn_musteri_listele.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_musteri_ara);
            this.groupBox1.Controls.Add(this.btn_musteri_ara);
            this.groupBox1.Controls.Add(this.btn_musteri_listele);
            this.groupBox1.Controls.Add(this.btn_musteri_sil);
            this.groupBox1.Controls.Add(this.btn_musteri_guncelle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 287);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // btn_musteri_sil
            // 
            this.btn_musteri_sil.Location = new System.Drawing.Point(6, 155);
            this.btn_musteri_sil.Name = "btn_musteri_sil";
            this.btn_musteri_sil.Size = new System.Drawing.Size(203, 61);
            this.btn_musteri_sil.TabIndex = 2;
            this.btn_musteri_sil.Text = "Müşteri Sil";
            this.btn_musteri_sil.UseVisualStyleBackColor = true;
            this.btn_musteri_sil.Click += new System.EventHandler(this.btn_musteri_sil_Click);
            // 
            // btn_musteri_ara
            // 
            this.btn_musteri_ara.Location = new System.Drawing.Point(6, 250);
            this.btn_musteri_ara.Name = "btn_musteri_ara";
            this.btn_musteri_ara.Size = new System.Drawing.Size(203, 31);
            this.btn_musteri_ara.TabIndex = 3;
            this.btn_musteri_ara.Text = "Müşteri Ara";
            this.btn_musteri_ara.UseVisualStyleBackColor = true;
            this.btn_musteri_ara.Click += new System.EventHandler(this.btn_musteri_ara_Click);
            // 
            // btn_musteri_guncelle
            // 
            this.btn_musteri_guncelle.Location = new System.Drawing.Point(6, 88);
            this.btn_musteri_guncelle.Name = "btn_musteri_guncelle";
            this.btn_musteri_guncelle.Size = new System.Drawing.Size(203, 61);
            this.btn_musteri_guncelle.TabIndex = 4;
            this.btn_musteri_guncelle.Text = "Müşteri Güncelle";
            this.btn_musteri_guncelle.UseVisualStyleBackColor = true;
            this.btn_musteri_guncelle.Click += new System.EventHandler(this.btn_musteri_guncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_temizle);
            this.groupBox2.Controls.Add(this.cmb_cinsiyet);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_Fiyat);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.txt_oda_no);
            this.groupBox2.Controls.Add(this.msk_tel_no);
            this.groupBox2.Controls.Add(this.msk_tc_no);
            this.groupBox2.Controls.Add(this.txt_musteri_soyadi);
            this.groupBox2.Controls.Add(this.txt_musteri_adi);
            this.groupBox2.Controls.Add(this.dtp_cikis_tarihi);
            this.groupBox2.Controls.Add(this.dtp_giris_tarihi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(234, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 282);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(148, 103);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(179, 24);
            this.cmb_cinsiyet.TabIndex = 46;
            this.cmb_cinsiyet.Text = "Bay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 22);
            this.label10.TabIndex = 45;
            this.label10.Text = "Cinsiyet :";
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(478, 77);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(200, 22);
            this.txt_Fiyat.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "Fiyat :";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(148, 200);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(179, 22);
            this.txt_email.TabIndex = 42;
            // 
            // txt_oda_no
            // 
            this.txt_oda_no.Enabled = false;
            this.txt_oda_no.Location = new System.Drawing.Point(474, 36);
            this.txt_oda_no.Name = "txt_oda_no";
            this.txt_oda_no.Size = new System.Drawing.Size(204, 22);
            this.txt_oda_no.TabIndex = 41;
            // 
            // msk_tel_no
            // 
            this.msk_tel_no.Location = new System.Drawing.Point(148, 168);
            this.msk_tel_no.Mask = "(999) 000-0000";
            this.msk_tel_no.Name = "msk_tel_no";
            this.msk_tel_no.Size = new System.Drawing.Size(179, 22);
            this.msk_tel_no.TabIndex = 40;
            // 
            // msk_tc_no
            // 
            this.msk_tc_no.Location = new System.Drawing.Point(148, 136);
            this.msk_tc_no.Mask = "00000000000";
            this.msk_tc_no.Name = "msk_tc_no";
            this.msk_tc_no.Size = new System.Drawing.Size(179, 22);
            this.msk_tc_no.TabIndex = 39;
            this.msk_tc_no.ValidatingType = typeof(int);
            // 
            // txt_musteri_soyadi
            // 
            this.txt_musteri_soyadi.Location = new System.Drawing.Point(148, 71);
            this.txt_musteri_soyadi.Name = "txt_musteri_soyadi";
            this.txt_musteri_soyadi.Size = new System.Drawing.Size(179, 22);
            this.txt_musteri_soyadi.TabIndex = 38;
            // 
            // txt_musteri_adi
            // 
            this.txt_musteri_adi.Location = new System.Drawing.Point(148, 39);
            this.txt_musteri_adi.Name = "txt_musteri_adi";
            this.txt_musteri_adi.Size = new System.Drawing.Size(179, 22);
            this.txt_musteri_adi.TabIndex = 37;
            // 
            // dtp_cikis_tarihi
            // 
            this.dtp_cikis_tarihi.Location = new System.Drawing.Point(478, 179);
            this.dtp_cikis_tarihi.Name = "dtp_cikis_tarihi";
            this.dtp_cikis_tarihi.Size = new System.Drawing.Size(200, 22);
            this.dtp_cikis_tarihi.TabIndex = 36;
            // 
            // dtp_giris_tarihi
            // 
            this.dtp_giris_tarihi.Location = new System.Drawing.Point(482, 132);
            this.dtp_giris_tarihi.Name = "dtp_giris_tarihi";
            this.dtp_giris_tarihi.Size = new System.Drawing.Size(196, 22);
            this.dtp_giris_tarihi.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Giriş Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Oda Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Çıkış Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "E-Posta Adresi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "T.C. Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Telefonu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Müşteri Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Müşteri Adı :";
            // 
            // txt_musteri_ara
            // 
            this.txt_musteri_ara.Location = new System.Drawing.Point(6, 222);
            this.txt_musteri_ara.Name = "txt_musteri_ara";
            this.txt_musteri_ara.Size = new System.Drawing.Size(202, 22);
            this.txt_musteri_ara.TabIndex = 5;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ID";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "AD";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "SOYAD";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "TEL";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "TC";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "E-POSTA";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "ODA";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "CİNSİYET";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "ÜCRET";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "GİRİŞ T.";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "ÇIKIŞ T.";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(475, 215);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(203, 61);
            this.btn_temizle.TabIndex = 6;
            this.btn_temizle.Text = "Alanları Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_musteri_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_musteri_ara;
        private System.Windows.Forms.Button btn_musteri_sil;
        private System.Windows.Forms.Button btn_musteri_guncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_oda_no;
        private System.Windows.Forms.MaskedTextBox msk_tel_no;
        private System.Windows.Forms.MaskedTextBox msk_tc_no;
        private System.Windows.Forms.TextBox txt_musteri_soyadi;
        private System.Windows.Forms.TextBox txt_musteri_adi;
        private System.Windows.Forms.DateTimePicker dtp_cikis_tarihi;
        private System.Windows.Forms.DateTimePicker dtp_giris_tarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_musteri_ara;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.Button btn_temizle;
    }
}