using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turkish_Idendity_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> kisi = new List<Kisi>();
        List<Hesap> hesap = new List<Hesap>();
        Kisi kisiNesne;
        Hesap hesapNesne;
        private void btn_bilgilerikaydet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Kişiyi kayıt etmekten eminmisiniz ?","Kaydet",MessageBoxButtons.YesNo);


            if (dialogResult==DialogResult.Yes)
            {
                kisiNesne = new Kisi
                {
                    _tcNo = txt_tcno.Text,
                    Ad = txt_ad.Text,
                    Soyad = txt_soyad.Text,
                    DogumYili = txt_dogumyili.Text,
                    Cinsiyet = cmb_cinsiyet.Text,
                    SeriNo = txt_serino.Text,
                    AnneAdi = txt_anneadi.Text,
                    BabaAdi = txt_babaadi.Text,
                    AnneKizlikSoyadi = txt_annekizliksoyadi.Text
                };
                string hesapNo = "";
                string ibanNo = "TR";
                Random rndHesapNo = new Random();
                Random rndIbanNo = new Random();
                for (int i = 0; i < 4; i++)
                {

                    hesapNo += rndHesapNo.Next(1000, 9999);
                }
                for (int i = 0; i < 16; i++)
                {

                    ibanNo += rndIbanNo.Next(0, 9);
                }

                kisi.Add(kisiNesne);
                groupBox2.Visible = true;
                txt_hesapno.Text = hesapNo;
                txt_iban.Text = ibanNo;
                txt_hesapno.Enabled = false;
                txt_iban.Enabled = false;
                MessageBox.Show("Kişi Başarıyla Kaydedildi.");
            }
           

           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;

        }

        private void btn_hesapolustur_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            
            hesapNesne = new Hesap
            {
                referansTcNo = txt_tcno.Text,
                HesapNo = txt_hesapno.Text,
                Iban = txt_iban.Text,
                SubeAdi = txt_subeadi.Text,
                Bakiye = txt_bakiye.Text,
                NakitAvansLimiti = txt_nakitavanslimiti.Text
            };
            hesap.Add(hesapNesne);
            groupBox2.Visible = false;
            txt_tcno.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_dogumyili.Clear();
            cmb_cinsiyet.Items.Clear();
            txt_serino.Clear();
            txt_anneadi.Clear();
            txt_babaadi.Clear();
            txt_annekizliksoyadi.Clear();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        string birinci = "";
        string ikinci = "";
        string kizlikadi = "";
        private void btn_ara_Click(object sender, EventArgs e)
        {
            string aranan = txt_hesap_kimlikno_ara.Text;
            if (aranan.Length == 11)
            {
                foreach (Hesap eleman in hesap)
                {
                    if (eleman.referansTcNo == aranan)
                    {
                       
                        foreach (Kisi eleman2 in kisi)
                        {
                            if (eleman2.TcNo == aranan)
                            {
                                int kizlik = eleman2.AnneKizlikSoyadi.Length;
                                kizlikadi = eleman2.AnneKizlikSoyadi;
                                Random rndKizlik = new Random();

                                for (int i = 0; i < 2; i++)
                                {
                                    if (i == 0)
                                    {
                                        birinci = rndKizlik.Next(1, kizlik).ToString();
                                    }
                                    else
                                    {
                                        ikinci = rndKizlik.Next(1, kizlik).ToString();
                                        while (birinci == ikinci)
                                        {
                                            ikinci = "";
                                            ikinci = rndKizlik.Next(0, kizlik).ToString();
                                        }

                                    }
                                }
                                MessageBox.Show("İlgili Kayıt Bulundu. Kayıt Bilgileri : " +eleman2.Ad+" "+eleman2.Soyad);
                                lbl_rastgelesayi_kizliksoyadi.Text = birinci + " ve " + ikinci;

                            }
                        }

                    }
                   
                }
            }
            else if (aranan.Length==16)
            {
                foreach (Hesap eleman in hesap)
                {
                    if (txt_hesap_kimlikno_ara.Text==eleman.HesapNo)
                    {
                        foreach (Hesap eleman2 in hesap)
                        {
                            if (eleman2.HesapNo == aranan)
                            {



                                int kizlik = eleman2.AnneKizlikSoyadi.Length;
                                kizlikadi = eleman2.AnneKizlikSoyadi;
                                Random rndKizlik = new Random();

                                for (int i = 0; i < 2; i++)
                                {
                                    if (i == 0)
                                    {
                                        birinci = rndKizlik.Next(1, kizlik).ToString();
                                    }
                                    else
                                    {
                                        ikinci = rndKizlik.Next(1, kizlik).ToString();
                                        while (birinci == ikinci)
                                        {
                                            ikinci = "";
                                            ikinci = rndKizlik.Next(0, kizlik).ToString();
                                        }

                                    }
                                }
                                MessageBox.Show("İlgili Kayıt Bulundu. Kayıt Bilgileri : " + eleman2.Ad + " " + eleman2.Soyad);
                                lbl_rastgelesayi_kizliksoyadi.Text = birinci + " ve " + ikinci;

                            }
                        }
                    }
                }
            }
        }

        private void btn_dogrula_Click(object sender, EventArgs e)
        {
            string dogrula = txt_dogrula.Text;

            int index1 = int.Parse(birinci) - 1;
            int index2 = int.Parse(ikinci) - 1;
            string key1 = kizlikadi[index1].ToString();
            string key2 = kizlikadi[index2].ToString();
          
            if (dogrula[0].ToString()==key1 && dogrula[1].ToString()==key2)
            {
                groupBox4.Visible = true;
                Hesap hsp = new Hesap();

                foreach (Hesap eleman in hesap)
                {
                    if (eleman.referansTcNo==txt_hesap_kimlikno_ara.Text)
                    {
                        lbl_hesap_no.Text = eleman.HesapNo;
                        lbl_iban.Text = eleman.Iban;
                        lbl_bakiye.Text = eleman.Bakiye;
                        MessageBox.Show("Bilgiler Doğrulandı.");

                    }
                    else if (eleman.HesapNo==txt_hesap_kimlikno_ara.Text)
                    {
                        lbl_hesap_no.Text = eleman.HesapNo;
                        lbl_iban.Text = eleman.Iban;
                        lbl_bakiye.Text = eleman.Bakiye;
                        MessageBox.Show("Bilgiler Doğrulandı.");

                    }
                }

                
            }

            txt_hesap_kimlikno_ara.Clear();
            txt_dogrula.Clear();
            lbl_rastgelesayi_kizliksoyadi.Text = ".";
        }

        private void btn_cek_Click(object sender, EventArgs e)
        {
            foreach (Hesap eleman in hesap)
            {
                if (eleman.HesapNo==lbl_hesap_no.Text)
                {
                    eleman.Bakiye = ((int.Parse(eleman.Bakiye)) - (int.Parse(txt_tutar.Text))).ToString();
                    lbl_bakiye.Text = eleman.Bakiye;
                }
            }
        }

        private void btn_yatir_Click(object sender, EventArgs e)
        {
            foreach (Hesap eleman in hesap)
            {
                if (eleman.HesapNo == lbl_hesap_no.Text)
                {
                    eleman.Bakiye = ((Convert.ToInt32(eleman.Bakiye)) + (Convert.ToInt32(txt_tutar.Text))).ToString();
                    lbl_bakiye.Text = eleman.Bakiye;

                }
            }
        }
    }
}
