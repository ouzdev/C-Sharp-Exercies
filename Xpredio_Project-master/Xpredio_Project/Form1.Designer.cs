namespace Xpredio_Project
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.dgwListele = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_kategori);
            this.groupBox1.Controls.Add(this.cmb_Kategori);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Adına Göre Listele";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Location = new System.Drawing.Point(115, 79);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(89, 17);
            this.lbl_kategori.TabIndex = 1;
            this.lbl_kategori.Text = "Kategori Seç";
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Location = new System.Drawing.Point(7, 117);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(275, 24);
            this.cmb_Kategori.TabIndex = 0;
            this.cmb_Kategori.SelectedIndexChanged += new System.EventHandler(this.cmb_Kategori_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_isim);
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İsme Göre Listele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim Yaz";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(6, 144);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(274, 22);
            this.txt_isim.TabIndex = 0;
            this.txt_isim.TextChanged += new System.EventHandler(this.txt_isim_TextChanged);
            // 
            // dgwListele
            // 
            this.dgwListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListele.Location = new System.Drawing.Point(319, 13);
            this.dgwListele.Name = "dgwListele";
            this.dgwListele.RowTemplate.Height = 24;
            this.dgwListele.Size = new System.Drawing.Size(895, 686);
            this.dgwListele.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1226, 711);
            this.Controls.Add(this.dgwListele);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Xpredio Search Screen v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwListele;
        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Label label1;
    }
}

