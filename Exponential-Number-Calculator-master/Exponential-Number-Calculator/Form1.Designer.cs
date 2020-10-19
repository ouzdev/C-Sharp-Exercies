namespace Exponential_Number_Calculator
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
            this.txt_taban_1 = new System.Windows.Forms.TextBox();
            this.txt_us_1 = new System.Windows.Forms.TextBox();
            this.txt_us_2 = new System.Windows.Forms.TextBox();
            this.txt_taban_2 = new System.Windows.Forms.TextBox();
            this.txt_sonuc_us = new System.Windows.Forms.TextBox();
            this.txt_sonuc_taban = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_taban_1
            // 
            this.txt_taban_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_taban_1.Location = new System.Drawing.Point(68, 67);
            this.txt_taban_1.Name = "txt_taban_1";
            this.txt_taban_1.Size = new System.Drawing.Size(61, 45);
            this.txt_taban_1.TabIndex = 0;
            // 
            // txt_us_1
            // 
            this.txt_us_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_us_1.Location = new System.Drawing.Point(110, 29);
            this.txt_us_1.Name = "txt_us_1";
            this.txt_us_1.Size = new System.Drawing.Size(41, 32);
            this.txt_us_1.TabIndex = 1;
            // 
            // txt_us_2
            // 
            this.txt_us_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_us_2.Location = new System.Drawing.Point(244, 29);
            this.txt_us_2.Name = "txt_us_2";
            this.txt_us_2.Size = new System.Drawing.Size(41, 32);
            this.txt_us_2.TabIndex = 3;
            // 
            // txt_taban_2
            // 
            this.txt_taban_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_taban_2.Location = new System.Drawing.Point(202, 67);
            this.txt_taban_2.Name = "txt_taban_2";
            this.txt_taban_2.Size = new System.Drawing.Size(61, 45);
            this.txt_taban_2.TabIndex = 2;
            // 
            // txt_sonuc_us
            // 
            this.txt_sonuc_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sonuc_us.Location = new System.Drawing.Point(384, 29);
            this.txt_sonuc_us.Name = "txt_sonuc_us";
            this.txt_sonuc_us.Size = new System.Drawing.Size(41, 32);
            this.txt_sonuc_us.TabIndex = 5;
            // 
            // txt_sonuc_taban
            // 
            this.txt_sonuc_taban.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sonuc_taban.Location = new System.Drawing.Point(342, 67);
            this.txt_sonuc_taban.Name = "txt_sonuc_taban";
            this.txt_sonuc_taban.Size = new System.Drawing.Size(61, 45);
            this.txt_sonuc_taban.TabIndex = 4;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(287, 77);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(39, 35);
            this.btn_hesapla.TabIndex = 6;
            this.btn_hesapla.Text = "=";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(152, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(525, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_sonuc_us);
            this.Controls.Add(this.txt_sonuc_taban);
            this.Controls.Add(this.txt_us_2);
            this.Controls.Add(this.txt_taban_2);
            this.Controls.Add(this.txt_us_1);
            this.Controls.Add(this.txt_taban_1);
            this.Name = "Form1";
            this.Text = "Exponential Number Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_taban_1;
        private System.Windows.Forms.TextBox txt_us_1;
        private System.Windows.Forms.TextBox txt_us_2;
        private System.Windows.Forms.TextBox txt_taban_2;
        private System.Windows.Forms.TextBox txt_sonuc_us;
        private System.Windows.Forms.TextBox txt_sonuc_taban;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
    }
}

