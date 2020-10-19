using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelCiftlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Hayvan> hayvanListe = new List<Hayvan>();
        List<PictureBox> hayvanResim = new List<PictureBox>();
        int CiftlikButce = 3000;
        int YemMiktarı = 1000;
        Hayvan hayvan;
        Random rastgeleKonum;
        int ciftlik_kapasite = 87;
        int sayac = 0;
        int sayac_inek = 0;
        int sayac_keci = 0;
        int sayac_tavuk = 0;
        Dictionary<int, string> HayvanFiyat = new Dictionary<int, string>();
        private void btn_hayvanEkle_Click(object sender, EventArgs e)
        {


            //Program çalıştığında ve hayvan eklendiğinde sadece bir kez çalıştırılacak kodlar.
            if (sayac == 0)
            {
                HayvanFiyat.Add(1000, "İnek");
                HayvanFiyat.Add(500, "Keçi");
                HayvanFiyat.Add(100, "Tavuk");
                timer1.Enabled = true;
                timer_level.Enabled = true;
                timer1.Interval = 5000;
                sayac++;
            }


            //Hangi hayvanın seçildiğini bulan kod.
            string secilen = cbm_hayvanListe.SelectedItem.ToString();
            //Seçilen hayvana göre fiyatı değişkende tutan kod.    
            var HayvanFiyatSonuc = HayvanFiyat.FirstOrDefault(x => x.Value == secilen);
            //Konumu rastgele oluşturan Random nesnesi.
            rastgeleKonum = new Random();

            //Eğer Çiftlik bütçesi hayvan adedine göre alıma yetiyormu ? 
            if (CiftlikButce >= ((HayvanFiyatSonuc.Key) * int.Parse(cbm_hayvanAdet.Text)))
            {
                // Çiftlik bütçesi hayvan alımına yetiyorsa çiftlik bütçesinden hayvan adedine göre toplam miktarı düşen kod.
                CiftlikButce -= ((HayvanFiyatSonuc.Key) * int.Parse(cbm_hayvanAdet.Text));
                //Bütçe label'lına güncel bütçeyi yazdıran kod.
                lbl_butce.Text = CiftlikButce.ToString();
                // Hayvan adedine ve hayvan türüne göre çalışan for döngüsü.
                for (int i = 0; i < int.Parse(cbm_hayvanAdet.Text); i++)
                {

                    //Eğer seçilen hayvan İnekse çalışacak kod satırı.

                    if (cbm_hayvanListe.Text == "İnek")
                    {
                        //Burada çiftlik kapasitesi kontrolü yapılmakta.
                        if (ciftlik_kapasite < int.Parse(cbm_hayvanAdet.Text))
                        {
                            MessageBox.Show("Çiftlikte yeterli alan malesefli kalmadı");
                            break;
                        }
                    // Goto yapısı kullanılarak picturebox dolu ise yeniden buraya dön ve tekrar nesne oluştur.
                    Etiket:
                        //0,'dan 87 ye kadar rastgele bir ID üreten kod satırı.
                        int rastgele_picturebox = rastgeleKonum.Next(0, 87);
                        // Burada HayvanResim nesnesininde daha önce bı ID ye sahip yada İlgili nesnenin resim metodu null ise yani bu picturebox boşsa yapılacak kod.
                        if (hayvanResim[rastgele_picturebox].Image == null)
                        {
                            //Yeni bir hayvan nesnesi üret.
                            hayvan = new Hayvan()
                            {
                                //İlgili değerleri doldur.
                                ID = rastgele_picturebox.ToString(),
                                X = hayvanResim[rastgele_picturebox].Location.X,
                                Y = hayvanResim[rastgele_picturebox].Location.Y,
                                AclikDurumu = 100,
                                HayvanTuru = "inek",
                                HayvanResimUrl = "C:\\inek.jpg",
                                MahsulUretim = 5,
                                YemTuketim = 5,

                            };
                            //İlgili picturebox'a hayvan trüne göre resim ataması yap.
                            hayvanResim[rastgele_picturebox].Image = Image.FromFile("C:\\inek.gif");
                            hayvanResim[rastgele_picturebox].SizeMode = PictureBoxSizeMode.StretchImage;
                            //Listeye nesneyi ekle.
                            hayvanListe.Add(hayvan);
                            //İnek sayacını bir arttır.
                            sayac_inek++;
                            //Çiftlik kapasitesini bir düşür.
                            ciftlik_kapasite--;

                        }
                        //Eğer Picturebox boş değil yani dolu ise yapıalacak kod.
                        else if (hayvanResim[rastgele_picturebox].Image != null)
                        {
                            //Etiket adresine geri git  satır: 77
                            goto Etiket;
                        }
                    }



                    else if (cbm_hayvanListe.Text == "Keçi")
                    {

                        if (ciftlik_kapasite < int.Parse(cbm_hayvanAdet.Text))
                        {
                            MessageBox.Show("Çiftlikte yeterli alan malesefli kalmadı");
                            break;
                        }
                    Etiket:
                        int rastgele_picturebox = rastgeleKonum.Next(0, 87);
                        if (hayvanResim[rastgele_picturebox].Image == null)
                        {
                            hayvan = new Hayvan()
                            {
                                ID = rastgele_picturebox.ToString(),
                                X = hayvanResim[rastgele_picturebox].Location.X,
                                Y = hayvanResim[rastgele_picturebox].Location.Y,
                                AclikDurumu = 100,
                                HayvanTuru = "Keçi",
                                MahsulUretim = 3,
                                HayvanResimUrl = "C:\\keci.jpg",

                                YemTuketim = 3
                            };
                            hayvanResim[rastgele_picturebox].Image = Image.FromFile("C:\\keci.jpg");
                            hayvanResim[rastgele_picturebox].SizeMode = PictureBoxSizeMode.StretchImage;
                            hayvanListe.Add(hayvan);
                            sayac_keci++;
                            ciftlik_kapasite--;

                        }
                        else if (hayvanResim[rastgele_picturebox].Image != null)
                        {

                            goto Etiket;
                        }

                    }
                    else
                    {

                        if (ciftlik_kapasite < int.Parse(cbm_hayvanAdet.Text))
                        {
                            MessageBox.Show("Çiftlikte yeterli alan malesefli kalmadı");
                            break;
                        }
                    Etiket:
                        int rastgele_picturebox = rastgeleKonum.Next(0, 87);
                        if (hayvanResim[rastgele_picturebox].Image == null)
                        {
                            hayvan = new Hayvan()
                            {
                                ID = rastgele_picturebox.ToString(),
                                X = hayvanResim[rastgele_picturebox].Location.X,
                                Y = hayvanResim[rastgele_picturebox].Location.Y,
                                AclikDurumu = 100,
                                HayvanTuru = "Tavuk",
                                MahsulUretim = 1,
                                HayvanResimUrl = "C:\\tavuk.gif",

                                YemTuketim = 1
                            };
                            hayvanResim[rastgele_picturebox].Image = Image.FromFile("C:\\tavuk.gif");
                            hayvanResim[rastgele_picturebox].SizeMode = PictureBoxSizeMode.StretchImage;
                            hayvanListe.Add(hayvan);
                            sayac_tavuk++;
                            ciftlik_kapasite--;

                        }
                        else if (hayvanResim[rastgele_picturebox].Image != null)
                        {

                            goto Etiket;
                        }
                    }
                }
            }
            //Eğer hayvan adenine göre fiyat bütçeyi aşıyorsa çalışacak kod satırı.
            else
            {
                MessageBox.Show("Bütçeniz Yetersiz.");
            }


        }

        //Burada form açıldığı anda çalışacak kodlar.
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_sat_inek_mahsul.Enabled = false;
            btn_sat_keci_mahsul.Enabled = false;
            btn_sat_tavuk_mahsul.Enabled = false;





            int sol = 0;
            int ust = 0;
            PictureBox[,] picture = new PictureBox[9, 12];
            for (int i = 0; i < picture.GetUpperBound(0); i++)
            {
                for (int j = 0; j < picture.GetUpperBound(1); j++)
                {
                    picture[i, j] = new PictureBox();
                    picture[i, j].Width = 50;
                    picture[i, j].Height = 50;
                    picture[i, j].Top = ust;
                    picture[i, j].Left = sol;
                    picture[i, j].BackColor = Color.Green;
                    sol += 50;
                    picture[i, j].Click += new EventHandler(Mesaj);
                    panel1.Controls.Add(picture[i, j]);
                    hayvanResim.Add(picture[i, j]);
                }
                ust += 50;
                sol = 0;
            }
            progressBar1.Value = YemMiktarı;
        }
        // Pictureboxlar ait konumlara göre picturebox bilgisini label aktarmaya yarayan Event kodları.
        void Mesaj(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int X_base = btn.Bounds.X;
            int Y_base = btn.Bounds.Y;

            foreach (var item in hayvanListe)
            {

                if (item.X == X_base && item.Y == Y_base)
                {
                    lbl_id.Text = item.ID;
                    lbl_turu.Text = item.HayvanTuru;
                    pb_AclikDurumu.Value = item.AclikDurumu;
                }
            }
        }
        //Belirlenen süreye göre rutin şekilde çalışacak Açlık bilgisi kod satırları.
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in hayvanListe)
            {
                if (item.HayvanTuru == "inek")
                {
                    item.AclikDurumu -= 3;

                }
                else if (item.HayvanTuru == "Keçi")
                {
                    item.AclikDurumu -= 2;

                }
                else if (item.HayvanTuru == "Tavuk")
                {
                    item.AclikDurumu -= 1;

                }
            }
        }
        //Hayvan besle butonuna tıklandığında çalışacak olan Hayvanların açlık durumunu 100 yapan ve hayvana göre yem miktarından değer düşen kod satırları.
        private void button7_Click(object sender, EventArgs e)
        {
            string hayvanId = lbl_id.Text;

            foreach (var item in hayvanListe)
            {
                if (item.ID == hayvanId)
                {
                    item.AclikDurumu = 100;
                    if (item.HayvanTuru == "inek")
                    {
                        YemMiktarı -= 5;
                        progressBar1.Value -= 5;
                    }
                    else if (item.HayvanTuru == "Keçi")
                    {
                        YemMiktarı -= 3;
                        progressBar1.Value -= 3;
                    }
                    else if (item.HayvanTuru == "Tavuk")
                    {
                        YemMiktarı -= 1;
                        progressBar1.Value -= 1;
                    }
                }
            }


        }
        //Burada ise belirli süreye göre Hayvanlardan üretim sağlayan ve bu üretimleri labellara yzzdıran kod satırları.
        private void timer_level_Tick(object sender, EventArgs e)
        {
            foreach (var mahsul in hayvanListe)
            {
                if (mahsul.HayvanTuru == "inek")
                {
                    mahsul.MahsulUretim += 5;

                }
                else if (mahsul.HayvanTuru == "Keçi")
                {
                    mahsul.MahsulUretim += 3;

                }
                else
                {
                    mahsul.MahsulUretim += 1;
                }

            }
            MahsulHesapla();
        }
        int nakliyatcı = 0;
        public void MahsulHesapla()
        {

            foreach (var MahsulHesapla in hayvanListe)
            {
                nakliyatcı++;
                if (MahsulHesapla.HayvanTuru == "inek")
                {
                    var sonucInek = +MahsulHesapla.MahsulUretim;
                    lbl_mahsul_inek.Text = sonucInek.ToString();
                }
                else if (MahsulHesapla.HayvanTuru == "Keçi")
                {
                    var sonucKeci = +MahsulHesapla.MahsulUretim;
                    lbl_mahsul_keci.Text = sonucKeci.ToString();
                }
                else
                {
                    var sonucTavuk = +MahsulHesapla.MahsulUretim;
                    lbl_mahsul_tavuk.Text = sonucTavuk.ToString();
                }

                if (nakliyatcı == 10)
                {
                    MessageBox.Show("Köyden esnaf geldi. Elindeki Ürünleri Satmalısın.");
                    foreach (char chr in lbl_mahsul_inek.Text)
                    {
                        if (Char.IsNumber(chr))
                        {
                            btn_sat_inek_mahsul.Enabled = true;
                        }
                        else
                        {
                            break;
                        }

                    }
                    foreach (char chr in lbl_mahsul_keci.Text)
                    {
                        if (Char.IsNumber(chr))
                        {
                            btn_sat_keci_mahsul.Enabled = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    foreach (char chr in lbl_mahsul_tavuk.Text)
                    {
                        if (Char.IsNumber(chr))
                        {
                            btn_sat_tavuk_mahsul.Enabled = true;
                        }
                        else
                        {
                            break;
                        }

                    }



                }
            }

        }

        private void btn_sat_inek_mahsul_Click(object sender, EventArgs e)
        {
            int inekMahsul = int.Parse(lbl_mahsul_inek.Text);
            int tahsilat = inekMahsul * 3;
            CiftlikButce +=tahsilat;
            lbl_mahsul_inek.Text = "0";
            lbl_butce.Text =(int.Parse(lbl_butce.Text)+ CiftlikButce).ToString();
        }

        private void btn_sat_keci_mahsul_Click(object sender, EventArgs e)
        {
            int KeciMahsul = int.Parse(lbl_mahsul_keci.Text);
            int tahsilat = KeciMahsul * 5;
            CiftlikButce+=tahsilat;
            lbl_mahsul_keci.Text = "0";
            lbl_butce.Text = (int.Parse(lbl_butce.Text) + CiftlikButce).ToString();
        }

        private void btn_sat_tavuk_mahsul_Click(object sender, EventArgs e)
        {
            int tavukMahsul = int.Parse(lbl_mahsul_tavuk.Text);
            int tahsilat = tavukMahsul * 1;
            CiftlikButce+=tahsilat;
            lbl_mahsul_tavuk.Text = "0";
            lbl_butce.Text = (int.Parse(lbl_butce.Text) + CiftlikButce).ToString();
        }
    }
}
