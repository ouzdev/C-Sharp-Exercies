namespace PixelCiftlik
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
            this.components = new System.ComponentModel.Container();
            this.cbm_hayvanListe = new System.Windows.Forms.ComboBox();
            this.cbm_hayvanAdet = new System.Windows.Forms.ComboBox();
            this.btn_hayvanEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_turu = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pb_AclikDurumu = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mahsul_inek = new System.Windows.Forms.Label();
            this.lbl_mahsul_keci = new System.Windows.Forms.Label();
            this.lbl_mahsul_tavuk = new System.Windows.Forms.Label();
            this.btn_sat_inek_mahsul = new System.Windows.Forms.Button();
            this.btn_sat_keci_mahsul = new System.Windows.Forms.Button();
            this.btn_sat_tavuk_mahsul = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_butce = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_level = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_level = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbm_hayvanListe
            // 
            this.cbm_hayvanListe.FormattingEnabled = true;
            this.cbm_hayvanListe.Items.AddRange(new object[] {
            "İnek",
            "Keçi",
            "Tavuk"});
            this.cbm_hayvanListe.Location = new System.Drawing.Point(23, 30);
            this.cbm_hayvanListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbm_hayvanListe.Name = "cbm_hayvanListe";
            this.cbm_hayvanListe.Size = new System.Drawing.Size(197, 24);
            this.cbm_hayvanListe.TabIndex = 1;
            // 
            // cbm_hayvanAdet
            // 
            this.cbm_hayvanAdet.FormattingEnabled = true;
            this.cbm_hayvanAdet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbm_hayvanAdet.Location = new System.Drawing.Point(227, 30);
            this.cbm_hayvanAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbm_hayvanAdet.Name = "cbm_hayvanAdet";
            this.cbm_hayvanAdet.Size = new System.Drawing.Size(76, 24);
            this.cbm_hayvanAdet.TabIndex = 2;
            // 
            // btn_hayvanEkle
            // 
            this.btn_hayvanEkle.Location = new System.Drawing.Point(320, 12);
            this.btn_hayvanEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hayvanEkle.Name = "btn_hayvanEkle";
            this.btn_hayvanEkle.Size = new System.Drawing.Size(120, 57);
            this.btn_hayvanEkle.TabIndex = 3;
            this.btn_hayvanEkle.Text = "Ekle";
            this.btn_hayvanEkle.UseVisualStyleBackColor = true;
            this.btn_hayvanEkle.Click += new System.EventHandler(this.btn_hayvanEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_turu);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.pb_AclikDurumu);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(764, 442);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(417, 210);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hayvan Bilgi Alanı";
            // 
            // lbl_turu
            // 
            this.lbl_turu.AutoSize = true;
            this.lbl_turu.Location = new System.Drawing.Point(123, 73);
            this.lbl_turu.Name = "lbl_turu";
            this.lbl_turu.Size = new System.Drawing.Size(54, 17);
            this.lbl_turu.TabIndex = 6;
            this.lbl_turu.Text = "label15";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(102, 37);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(54, 17);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "label14";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(268, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 40);
            this.button7.TabIndex = 4;
            this.button7.Text = "Hayvanı Besle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pb_AclikDurumu
            // 
            this.pb_AclikDurumu.Location = new System.Drawing.Point(177, 103);
            this.pb_AclikDurumu.Name = "pb_AclikDurumu";
            this.pb_AclikDurumu.Size = new System.Drawing.Size(218, 23);
            this.pb_AclikDurumu.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Hayvan Açlık Durumu :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Hayvan Türü :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hayvan ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "İnek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Keçi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tavuk";
            // 
            // lbl_mahsul_inek
            // 
            this.lbl_mahsul_inek.AutoSize = true;
            this.lbl_mahsul_inek.Location = new System.Drawing.Point(51, 98);
            this.lbl_mahsul_inek.Name = "lbl_mahsul_inek";
            this.lbl_mahsul_inek.Size = new System.Drawing.Size(34, 17);
            this.lbl_mahsul_inek.TabIndex = 8;
            this.lbl_mahsul_inek.Text = "İnek";
            // 
            // lbl_mahsul_keci
            // 
            this.lbl_mahsul_keci.AutoSize = true;
            this.lbl_mahsul_keci.Location = new System.Drawing.Point(124, 98);
            this.lbl_mahsul_keci.Name = "lbl_mahsul_keci";
            this.lbl_mahsul_keci.Size = new System.Drawing.Size(35, 17);
            this.lbl_mahsul_keci.TabIndex = 9;
            this.lbl_mahsul_keci.Text = "Keçi";
            // 
            // lbl_mahsul_tavuk
            // 
            this.lbl_mahsul_tavuk.AutoSize = true;
            this.lbl_mahsul_tavuk.Location = new System.Drawing.Point(186, 98);
            this.lbl_mahsul_tavuk.Name = "lbl_mahsul_tavuk";
            this.lbl_mahsul_tavuk.Size = new System.Drawing.Size(47, 17);
            this.lbl_mahsul_tavuk.TabIndex = 10;
            this.lbl_mahsul_tavuk.Text = "Tavuk";
            // 
            // btn_sat_inek_mahsul
            // 
            this.btn_sat_inek_mahsul.Location = new System.Drawing.Point(42, 133);
            this.btn_sat_inek_mahsul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sat_inek_mahsul.Name = "btn_sat_inek_mahsul";
            this.btn_sat_inek_mahsul.Size = new System.Drawing.Size(51, 23);
            this.btn_sat_inek_mahsul.TabIndex = 11;
            this.btn_sat_inek_mahsul.Text = "SAT";
            this.btn_sat_inek_mahsul.UseVisualStyleBackColor = true;
            this.btn_sat_inek_mahsul.Click += new System.EventHandler(this.btn_sat_inek_mahsul_Click);
            // 
            // btn_sat_keci_mahsul
            // 
            this.btn_sat_keci_mahsul.Location = new System.Drawing.Point(117, 133);
            this.btn_sat_keci_mahsul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sat_keci_mahsul.Name = "btn_sat_keci_mahsul";
            this.btn_sat_keci_mahsul.Size = new System.Drawing.Size(51, 23);
            this.btn_sat_keci_mahsul.TabIndex = 11;
            this.btn_sat_keci_mahsul.Text = "SAT";
            this.btn_sat_keci_mahsul.UseVisualStyleBackColor = true;
            this.btn_sat_keci_mahsul.Click += new System.EventHandler(this.btn_sat_keci_mahsul_Click);
            // 
            // btn_sat_tavuk_mahsul
            // 
            this.btn_sat_tavuk_mahsul.Location = new System.Drawing.Point(190, 133);
            this.btn_sat_tavuk_mahsul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sat_tavuk_mahsul.Name = "btn_sat_tavuk_mahsul";
            this.btn_sat_tavuk_mahsul.Size = new System.Drawing.Size(51, 23);
            this.btn_sat_tavuk_mahsul.TabIndex = 13;
            this.btn_sat_tavuk_mahsul.Text = "SAT";
            this.btn_sat_tavuk_mahsul.UseVisualStyleBackColor = true;
            this.btn_sat_tavuk_mahsul.Click += new System.EventHandler(this.btn_sat_tavuk_mahsul_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lbl_butce);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(769, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(417, 191);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detaylar";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(147, 89);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(264, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 1000;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 144);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "Yem Al";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(131, 144);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Diğer Güne Geç";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 144);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "İstatislikler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl_butce
            // 
            this.lbl_butce.AutoSize = true;
            this.lbl_butce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_butce.Location = new System.Drawing.Point(159, 28);
            this.lbl_butce.Name = "lbl_butce";
            this.lbl_butce.Size = new System.Drawing.Size(69, 29);
            this.lbl_butce.TabIndex = 3;
            this.lbl_butce.Text = "3000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "YEM MİKTARI :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ÇİFTLİĞİN BÜTÇESİ(₺) :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 500);
            this.panel1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_level
            // 
            this.timer_level.Interval = 6000;
            this.timer_level.Tick += new System.EventHandler(this.timer_level_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sat_tavuk_mahsul);
            this.groupBox3.Controls.Add(this.btn_sat_keci_mahsul);
            this.groupBox3.Controls.Add(this.btn_sat_inek_mahsul);
            this.groupBox3.Controls.Add(this.lbl_mahsul_tavuk);
            this.groupBox3.Controls.Add(this.lbl_mahsul_keci);
            this.groupBox3.Controls.Add(this.lbl_mahsul_inek);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(764, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 211);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mahsüller";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_level);
            this.groupBox4.Location = new System.Drawing.Point(1037, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 211);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Level";
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_level.Location = new System.Drawing.Point(30, 87);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(92, 29);
            this.lbl_level.TabIndex = 0;
            this.lbl_level.Text = "LEVEL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 663);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_hayvanEkle);
            this.Controls.Add(this.cbm_hayvanAdet);
            this.Controls.Add(this.cbm_hayvanListe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbm_hayvanListe;
        private System.Windows.Forms.ComboBox cbm_hayvanAdet;
        private System.Windows.Forms.Button btn_hayvanEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mahsul_inek;
        private System.Windows.Forms.Label lbl_mahsul_keci;
        private System.Windows.Forms.Label lbl_mahsul_tavuk;
        private System.Windows.Forms.Button btn_sat_inek_mahsul;
        private System.Windows.Forms.Button btn_sat_keci_mahsul;
        private System.Windows.Forms.Button btn_sat_tavuk_mahsul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_butce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ProgressBar pb_AclikDurumu;
        private System.Windows.Forms.Label lbl_turu;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_level;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_level;
    }
}

