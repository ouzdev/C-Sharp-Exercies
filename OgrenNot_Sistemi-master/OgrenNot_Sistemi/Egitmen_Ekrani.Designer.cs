namespace OgrenNot_Sistemi
{
    partial class Egitmen_Ekrani
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ogrenci_soyad = new System.Windows.Forms.TextBox();
            this.btn_ogrenci_ekle = new System.Windows.Forms.Button();
            this.txt_ogrenci_ad = new System.Windows.Forms.TextBox();
            this.msk_ogrenci_mumara = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_birinci_sinav_notu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ucuncu_sinav_notu = new System.Windows.Forms.TextBox();
            this.btn_not_ekle = new System.Windows.Forms.Button();
            this.txt_ikinci_sinav_notu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_sinif_ortalama = new System.Windows.Forms.Label();
            this.lbl_gecen_sayisi = new System.Windows.Forms.Label();
            this.lbl_kalan_sayisi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSinav1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSinav2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSinav3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet = new OgrenNot_Sistemi.DbNotKayitDataSet();
            this.dersTableTableAdapter = new OgrenNot_Sistemi.DbNotKayitDataSetTableAdapters.DersTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ogrenci_soyad);
            this.groupBox1.Controls.Add(this.btn_ogrenci_ekle);
            this.groupBox1.Controls.Add(this.txt_ogrenci_ad);
            this.groupBox1.Controls.Add(this.msk_ogrenci_mumara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Öğrenci Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyadı :";
            // 
            // txt_ogrenci_soyad
            // 
            this.txt_ogrenci_soyad.Location = new System.Drawing.Point(431, 46);
            this.txt_ogrenci_soyad.Name = "txt_ogrenci_soyad";
            this.txt_ogrenci_soyad.Size = new System.Drawing.Size(122, 22);
            this.txt_ogrenci_soyad.TabIndex = 5;
            // 
            // btn_ogrenci_ekle
            // 
            this.btn_ogrenci_ekle.Location = new System.Drawing.Point(584, 42);
            this.btn_ogrenci_ekle.Name = "btn_ogrenci_ekle";
            this.btn_ogrenci_ekle.Size = new System.Drawing.Size(134, 31);
            this.btn_ogrenci_ekle.TabIndex = 4;
            this.btn_ogrenci_ekle.Text = "Öğrenci Ekle";
            this.btn_ogrenci_ekle.UseVisualStyleBackColor = true;
            this.btn_ogrenci_ekle.Click += new System.EventHandler(this.btn_ogrenci_ekle_Click);
            // 
            // txt_ogrenci_ad
            // 
            this.txt_ogrenci_ad.Location = new System.Drawing.Point(234, 46);
            this.txt_ogrenci_ad.Name = "txt_ogrenci_ad";
            this.txt_ogrenci_ad.Size = new System.Drawing.Size(117, 22);
            this.txt_ogrenci_ad.TabIndex = 3;
            // 
            // msk_ogrenci_mumara
            // 
            this.msk_ogrenci_mumara.Location = new System.Drawing.Point(92, 46);
            this.msk_ogrenci_mumara.Mask = "0000";
            this.msk_ogrenci_mumara.Name = "msk_ogrenci_mumara";
            this.msk_ogrenci_mumara.Size = new System.Drawing.Size(67, 22);
            this.msk_ogrenci_mumara.TabIndex = 2;
            this.msk_ogrenci_mumara.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numarası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_birinci_sinav_notu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_ucuncu_sinav_notu);
            this.groupBox2.Controls.Add(this.btn_not_ekle);
            this.groupBox2.Controls.Add(this.txt_ikinci_sinav_notu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 96);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // txt_birinci_sinav_notu
            // 
            this.txt_birinci_sinav_notu.Location = new System.Drawing.Point(60, 46);
            this.txt_birinci_sinav_notu.Name = "txt_birinci_sinav_notu";
            this.txt_birinci_sinav_notu.Size = new System.Drawing.Size(117, 22);
            this.txt_birinci_sinav_notu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "1. Sınav Notu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "3. Sınav Notu";
            // 
            // txt_ucuncu_sinav_notu
            // 
            this.txt_ucuncu_sinav_notu.Location = new System.Drawing.Point(431, 46);
            this.txt_ucuncu_sinav_notu.Name = "txt_ucuncu_sinav_notu";
            this.txt_ucuncu_sinav_notu.Size = new System.Drawing.Size(122, 22);
            this.txt_ucuncu_sinav_notu.TabIndex = 5;
            // 
            // btn_not_ekle
            // 
            this.btn_not_ekle.Location = new System.Drawing.Point(584, 42);
            this.btn_not_ekle.Name = "btn_not_ekle";
            this.btn_not_ekle.Size = new System.Drawing.Size(134, 31);
            this.btn_not_ekle.TabIndex = 4;
            this.btn_not_ekle.Text = "Not Ekle";
            this.btn_not_ekle.UseVisualStyleBackColor = true;
            this.btn_not_ekle.Click += new System.EventHandler(this.btn_not_ekle_Click);
            // 
            // txt_ikinci_sinav_notu
            // 
            this.txt_ikinci_sinav_notu.Location = new System.Drawing.Point(234, 46);
            this.txt_ikinci_sinav_notu.Name = "txt_ikinci_sinav_notu";
            this.txt_ikinci_sinav_notu.Size = new System.Drawing.Size(117, 22);
            this.txt_ikinci_sinav_notu.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "2. Sınav Notu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_sinif_ortalama);
            this.groupBox3.Controls.Add(this.lbl_gecen_sayisi);
            this.groupBox3.Controls.Add(this.lbl_kalan_sayisi);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(13, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Genel Durum";
            // 
            // lbl_sinif_ortalama
            // 
            this.lbl_sinif_ortalama.AutoSize = true;
            this.lbl_sinif_ortalama.Location = new System.Drawing.Point(580, 57);
            this.lbl_sinif_ortalama.Name = "lbl_sinif_ortalama";
            this.lbl_sinif_ortalama.Size = new System.Drawing.Size(24, 17);
            this.lbl_sinif_ortalama.TabIndex = 5;
            this.lbl_sinif_ortalama.Text = "00";
            // 
            // lbl_gecen_sayisi
            // 
            this.lbl_gecen_sayisi.AutoSize = true;
            this.lbl_gecen_sayisi.Location = new System.Drawing.Point(182, 57);
            this.lbl_gecen_sayisi.Name = "lbl_gecen_sayisi";
            this.lbl_gecen_sayisi.Size = new System.Drawing.Size(24, 17);
            this.lbl_gecen_sayisi.TabIndex = 4;
            this.lbl_gecen_sayisi.Text = "00";
            // 
            // lbl_kalan_sayisi
            // 
            this.lbl_kalan_sayisi.AutoSize = true;
            this.lbl_kalan_sayisi.Location = new System.Drawing.Point(377, 57);
            this.lbl_kalan_sayisi.Name = "lbl_kalan_sayisi";
            this.lbl_kalan_sayisi.Size = new System.Drawing.Size(24, 17);
            this.lbl_kalan_sayisi.TabIndex = 3;
            this.lbl_kalan_sayisi.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sınıf Ortalaması";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sınavdan Kalan Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sınavı Geçen Sayısı";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 343);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrenci Durum Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIdDataGridViewTextBoxColumn,
            this.ogrenciNoDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciSinav1DataGridViewTextBoxColumn,
            this.ogrenciSinav2DataGridViewTextBoxColumn,
            this.ogrenciSinav3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.dersTableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrenciIdDataGridViewTextBoxColumn
            // 
            this.ogrenciIdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.HeaderText = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.Name = "ogrenciIdDataGridViewTextBoxColumn";
            this.ogrenciIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciNoDataGridViewTextBoxColumn
            // 
            this.ogrenciNoDataGridViewTextBoxColumn.DataPropertyName = "OgrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.HeaderText = "OgrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.Name = "ogrenciNoDataGridViewTextBoxColumn";
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            // 
            // ogrenciSinav1DataGridViewTextBoxColumn
            // 
            this.ogrenciSinav1DataGridViewTextBoxColumn.DataPropertyName = "OgrenciSinav1";
            this.ogrenciSinav1DataGridViewTextBoxColumn.HeaderText = "OgrenciSinav1";
            this.ogrenciSinav1DataGridViewTextBoxColumn.Name = "ogrenciSinav1DataGridViewTextBoxColumn";
            // 
            // ogrenciSinav2DataGridViewTextBoxColumn
            // 
            this.ogrenciSinav2DataGridViewTextBoxColumn.DataPropertyName = "OgrenciSinav2";
            this.ogrenciSinav2DataGridViewTextBoxColumn.HeaderText = "OgrenciSinav2";
            this.ogrenciSinav2DataGridViewTextBoxColumn.Name = "ogrenciSinav2DataGridViewTextBoxColumn";
            // 
            // ogrenciSinav3DataGridViewTextBoxColumn
            // 
            this.ogrenciSinav3DataGridViewTextBoxColumn.DataPropertyName = "OgrenciSinav3";
            this.ogrenciSinav3DataGridViewTextBoxColumn.HeaderText = "OgrenciSinav3";
            this.ogrenciSinav3DataGridViewTextBoxColumn.Name = "ogrenciSinav3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // dersTableBindingSource
            // 
            this.dersTableBindingSource.DataMember = "DersTable";
            this.dersTableBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersTableTableAdapter
            // 
            this.dersTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Öğrenciyi Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Egitmen_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 748);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Egitmen_Ekrani";
            this.Text = "OgrenNot Eğitmen Sayfası";
            this.Load += new System.EventHandler(this.Egitmen_Ekrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ogrenci_soyad;
        private System.Windows.Forms.Button btn_ogrenci_ekle;
        private System.Windows.Forms.TextBox txt_ogrenci_ad;
        private System.Windows.Forms.MaskedTextBox msk_ogrenci_mumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_birinci_sinav_notu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ucuncu_sinav_notu;
        private System.Windows.Forms.Button btn_not_ekle;
        private System.Windows.Forms.TextBox txt_ikinci_sinav_notu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_sinif_ortalama;
        private System.Windows.Forms.Label lbl_gecen_sayisi;
        private System.Windows.Forms.Label lbl_kalan_sayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource dersTableBindingSource;
        private DbNotKayitDataSetTableAdapters.DersTableTableAdapter dersTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSinav1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSinav2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSinav3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}