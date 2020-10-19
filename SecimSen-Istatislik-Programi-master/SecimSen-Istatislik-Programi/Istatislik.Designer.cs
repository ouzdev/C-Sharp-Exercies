namespace SecimSen_Istatislik_Programi
{
    partial class Istatislik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartPartiler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_e = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbar_etoplulugu = new System.Windows.Forms.ProgressBar();
            this.pbar_dtoplulugu = new System.Windows.Forms.ProgressBar();
            this.pbar_ctoplulugu = new System.Windows.Forms.ProgressBar();
            this.pbar_btoplulugu = new System.Windows.Forms.ProgressBar();
            this.pbar_atoplulugu = new System.Windows.Forms.ProgressBar();
            this.cmb_bolgesec = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPartiler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartPartiler);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Oy Oranları";
            // 
            // chartPartiler
            // 
            this.chartPartiler.BackColor = System.Drawing.Color.Violet;
            this.chartPartiler.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.chartPartiler.ChartAreas.Add(chartArea2);
            this.chartPartiler.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartPartiler.Legends.Add(legend2);
            this.chartPartiler.Location = new System.Drawing.Point(3, 18);
            this.chartPartiler.Name = "chartPartiler";
            this.chartPartiler.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Topluluklar";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartPartiler.Series.Add(series2);
            this.chartPartiler.Size = new System.Drawing.Size(941, 350);
            this.chartPartiler.TabIndex = 0;
            this.chartPartiler.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_e);
            this.groupBox2.Controls.Add(this.lbl_d);
            this.groupBox2.Controls.Add(this.lbl_c);
            this.groupBox2.Controls.Add(this.lbl_b);
            this.groupBox2.Controls.Add(this.lbl_a);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pbar_etoplulugu);
            this.groupBox2.Controls.Add(this.pbar_dtoplulugu);
            this.groupBox2.Controls.Add(this.pbar_ctoplulugu);
            this.groupBox2.Controls.Add(this.pbar_btoplulugu);
            this.groupBox2.Controls.Add(this.pbar_atoplulugu);
            this.groupBox2.Controls.Add(this.cmb_bolgesec);
            this.groupBox2.Location = new System.Drawing.Point(13, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bölge Seçim Paneli";
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_e.Location = new System.Drawing.Point(884, 310);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(27, 29);
            this.lbl_e.TabIndex = 16;
            this.lbl_e.Text = "0";
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_d.Location = new System.Drawing.Point(884, 268);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(27, 29);
            this.lbl_d.TabIndex = 15;
            this.lbl_d.Text = "0";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_c.Location = new System.Drawing.Point(884, 224);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(27, 29);
            this.lbl_c.TabIndex = 14;
            this.lbl_c.Text = "0";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_b.Location = new System.Drawing.Point(884, 181);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(27, 29);
            this.lbl_b.TabIndex = 13;
            this.lbl_b.Text = "0";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_a.Location = new System.Drawing.Point(884, 136);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(27, 29);
            this.lbl_a.TabIndex = 12;
            this.lbl_a.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(421, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "BÖLGE SEÇ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "E Topluluğu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "D Topluluğu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "C Topluluğu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "B Topluluğu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "A Topluluğu :";
            // 
            // pbar_etoplulugu
            // 
            this.pbar_etoplulugu.Location = new System.Drawing.Point(202, 312);
            this.pbar_etoplulugu.Maximum = 1000;
            this.pbar_etoplulugu.Name = "pbar_etoplulugu";
            this.pbar_etoplulugu.Size = new System.Drawing.Size(667, 38);
            this.pbar_etoplulugu.TabIndex = 5;
            // 
            // pbar_dtoplulugu
            // 
            this.pbar_dtoplulugu.Location = new System.Drawing.Point(202, 268);
            this.pbar_dtoplulugu.Maximum = 1000;
            this.pbar_dtoplulugu.Name = "pbar_dtoplulugu";
            this.pbar_dtoplulugu.Size = new System.Drawing.Size(667, 38);
            this.pbar_dtoplulugu.TabIndex = 4;
            // 
            // pbar_ctoplulugu
            // 
            this.pbar_ctoplulugu.Location = new System.Drawing.Point(202, 224);
            this.pbar_ctoplulugu.Maximum = 1000;
            this.pbar_ctoplulugu.Name = "pbar_ctoplulugu";
            this.pbar_ctoplulugu.Size = new System.Drawing.Size(667, 38);
            this.pbar_ctoplulugu.TabIndex = 3;
            // 
            // pbar_btoplulugu
            // 
            this.pbar_btoplulugu.Location = new System.Drawing.Point(202, 180);
            this.pbar_btoplulugu.Maximum = 1000;
            this.pbar_btoplulugu.Name = "pbar_btoplulugu";
            this.pbar_btoplulugu.Size = new System.Drawing.Size(667, 38);
            this.pbar_btoplulugu.TabIndex = 2;
            // 
            // pbar_atoplulugu
            // 
            this.pbar_atoplulugu.Location = new System.Drawing.Point(202, 136);
            this.pbar_atoplulugu.Maximum = 1000;
            this.pbar_atoplulugu.Name = "pbar_atoplulugu";
            this.pbar_atoplulugu.Size = new System.Drawing.Size(667, 38);
            this.pbar_atoplulugu.TabIndex = 1;
            // 
            // cmb_bolgesec
            // 
            this.cmb_bolgesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_bolgesec.FormattingEnabled = true;
            this.cmb_bolgesec.Location = new System.Drawing.Point(279, 66);
            this.cmb_bolgesec.Name = "cmb_bolgesec";
            this.cmb_bolgesec.Size = new System.Drawing.Size(439, 37);
            this.cmb_bolgesec.TabIndex = 0;
            this.cmb_bolgesec.SelectedIndexChanged += new System.EventHandler(this.cmb_bolgesec_SelectedIndexChanged);
            // 
            // Istatislik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(972, 797);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Istatislik";
            this.Text = "Istatislik";
            this.Load += new System.EventHandler(this.Istatislik_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPartiler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPartiler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbar_etoplulugu;
        private System.Windows.Forms.ProgressBar pbar_dtoplulugu;
        private System.Windows.Forms.ProgressBar pbar_ctoplulugu;
        private System.Windows.Forms.ProgressBar pbar_btoplulugu;
        private System.Windows.Forms.ProgressBar pbar_atoplulugu;
        private System.Windows.Forms.ComboBox cmb_bolgesec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_a;
    }
}