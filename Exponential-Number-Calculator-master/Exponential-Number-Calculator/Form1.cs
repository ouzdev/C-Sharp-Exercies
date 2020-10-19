using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Number_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            // 1. uslu sayıyı Uslu sınıfından nesne oluşturarak değerleri nesneye aktarıyorum.

            Uslu sayi1 = new Uslu();
            sayi1.taban = Convert.ToInt32(txt_taban_1.Text);
            sayi1.us = Convert.ToInt32(txt_us_1.Text);

            //--------------------------------------------------------------------------------

            Uslu sayi2 = new Uslu();
            sayi2.taban = Convert.ToInt32(txt_taban_2.Text);
            sayi2.us = Convert.ToInt32(txt_us_2.Text);


            //--------------------------------------------------------------------------------
            //Nesnelere değer atamalarını yaptım. Sonraki süreçte bu nesneleri matematik sınıfına gönderip ilgili işlemleri yaptırıyor olacağım.
            
            Matematik matematik = new Matematik();
            //Matematik sınıfının hesapla metoduna nesnelerimi gönderdim.
            //Geri dönen değeri var tipinde sonuc adında değişkende tuttum.
            var sonuc = matematik.Hesapla(sayi1, sayi2);
            // sonuc değişkenlerindeki değerleri textboxlara atamasını yaptım.
            txt_sonuc_taban.Text = sonuc.taban.ToString();
            txt_sonuc_us.Text = sonuc.us.ToString();

        }
    }
}
