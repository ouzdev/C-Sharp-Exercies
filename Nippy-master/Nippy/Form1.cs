using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nippy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Koleksiyon kullanrak ogrenci Listesi oluşturdum.
        List<Student> ogrenciListe = new List<Student>();

        // Koleksiyon kullanrak veli listesi oluşturdum.
        List<Detay> veliListesi = new List<Detay>();


        // Öğrenci sınıfından ogr adında referans adı oluşturdum. Bu referans adını kod bloğunda newliyerek kayıt bilgilerini tutacağım.
        public Student ogr;

        //Detay sayfasından veli adında bir referans adı oluşturdum. Bu referans adını kod bloğunda newliyerek kayıt bilgilerini tutacağım.
        private Detay veli;

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            // Kontrol adında boolean değişken tanımladım. Bu değişken eğer kayıtlarda aynı öğrenci numarası var ise direk olarak false olup ilgili hatayı ekrana göstermede yardımcı olacak.
            bool kontrol = true;


            //Gerekli şartlarımı oluşturdum.
            if (txt_no.Text != "" && txt_ogrenciAdi.Text != "" && txt_ogrenciSoyadi.Text != "")
            {
                //Öğrenci numara kontrolü yaptım.
                foreach (Student eleman in ogrenciListe)
                {
                    if (eleman.OgrenciNo == txt_no.Text)
                    {
                        kontrol = false;
                        break;

                    }
                }
                //Öğrenci numarası hiçbir kayıt ile eşleşmiyorsa kayıtımı listeme ekledim.
                if (kontrol)
                {
                    ogr = new Student(txt_no.Text, txt_ogrenciAdi.Text, txt_ogrenciSoyadi.Text);
                    ogrenciListe.Add(ogr);
                    lst_liste.Items.Add(ogr.OgrenciNo);
                    cmb_ogrenciNo.Items.Clear();
                    foreach (Student eleman in ogrenciListe)
                    {
                       
                        cmb_ogrenciNo.Items.Add(eleman.OgrenciNo);
                    }
                    MessageBox.Show("Öğrenci başarıyla kaydedildi.");


                }
                //Eğer eşleşiyorsa hatamı ekrana bastım.
                else
                {
                    MessageBox.Show("Kayıtlı bir öğrenci numarası girdiniz. Lütfen Farklı bir öğrenci numarası girerek tekrar deneyiniz.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------TEXTBOXLARA DEĞER ATAMA----------------------------------------------
        // Listboxdaki seçilen itemin içeriğini döngü yardımı ile ogrenciListe koleksiyonundan bulup textboxlara yazdırıyorum.
        private void lst_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = lst_liste.SelectedItem.ToString();

            foreach (Student eleman in ogrenciListe)
            {
                if (eleman.OgrenciNo == index)
                {
                    ogr = eleman;


                }

            }

            txt_no_update.Text = ogr.OgrenciNo;
            txt_ad_update.Text = ogr.OgrenciAdı;
            txt_soyad_update.Text = ogr.OgrenciSoyadi;
            lbl_devamsizlik.Text = ogr.Devamsizlik;
            chk_aidat.Checked = ogr.Aidat;
        }
        //-----------------------------------------------------TEXTBOXLARA DEĞER ATAMA---END-------------------------------------------





        //----------------------------------------------------DEVAMSIZLIK DEĞERİ ARTTIRMA-----------------------------------------------------
        private void btn_devamsizlik_Click(object sender, EventArgs e)
        {
            lbl_devamsizlik.Text = (Convert.ToInt32(lbl_devamsizlik.Text) + 1).ToString();
        }
        //----------------------------------------------------DEVAMSIZLIK DEĞERİ ARTTIRMA--END------------------------------------------------



        //----------------------------------------------------KAYIT GÜNCELLEME İŞLEMLERİ------------------------------------------------------
        // Textboxlardaki değerleri nesneme aktarımını sağlıyorum. Sonrasında tüm kayıtları tekrar listboxa aktarıyorum.
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            lst_liste.Items.Clear();
            ogr.OgrenciNo = txt_no_update.Text;
            ogr.OgrenciAdı = txt_ad_update.Text;
            ogr.OgrenciSoyadi = txt_ogrenciSoyadi.Text;
            ogr.Devamsizlik = lbl_devamsizlik.Text;
            ogr.Aidat = chk_aidat.Checked;

            foreach (Student eleman in ogrenciListe)
            {
                lst_liste.Items.Add(eleman.OgrenciNo);
            }

            txt_no_update.Clear();
            txt_ad_update.Clear();
            txt_soyad_update.Clear();
            lbl_devamsizlik.Text = "0";
            chk_aidat.Checked = false;

        }

        private void cmb_ogrenciNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = cmb_ogrenciNo.SelectedItem.ToString();

            foreach (Student eleman in ogrenciListe)
            {
                if (eleman.OgrenciNo == index)
                {
                    ogr = eleman;
                }
            }

            lbl_detay_ogrenciad.Text = ogr.OgrenciAdı+" "+ogr.OgrenciSoyadi;
        }
        
        private void btn_detay_ekle_Click(object sender, EventArgs e)
        {
            veli=new Detay();
            {
                veli.ogrenciNo = cmb_ogrenciNo.SelectedItem.ToString();
                veli.veliAdSoyad = txt_veliadi.Text;
                veli.adres = txt_adres.Text;
                veli.telefon = txt_telefon.Text;
            }

            veliListesi.Add(veli);
        }

        private void btn_detay_Click(object sender, EventArgs e)
        {
            string index = lst_liste.SelectedItem.ToString();
            foreach (Student eleman in ogrenciListe)
            {
                if (eleman.OgrenciNo == index)
                {
                    ogr = eleman;
                }
            }
            foreach (Detay eleman in veliListesi)
            {
                if (eleman.ogrenciNo == index)
                {
                    veli = eleman;
                }
            }
            Detay_Formu frm = new Detay_Formu(ogr,veli);

          
            frm.Show();


        }


        //----------------------------------------------------KAYIT GÜNCELLEME İŞLEMLERİ----END-----------------------------------------------
    }
}
