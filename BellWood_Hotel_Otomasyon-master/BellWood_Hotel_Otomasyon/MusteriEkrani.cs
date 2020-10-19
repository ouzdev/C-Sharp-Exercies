using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BellWood_Hotel_Otomasyon
{
    public partial class MusteriEkrani : Form
    {
        //Data Source=.\SQLEXPRESS;Initial Catalog=BellWoodHotels;Integrated Security=True
        public MusteriEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BellWoodHotels;Integrated Security=True");

        private void btnOda1001_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "1001";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1001 (Adi,Soyadi) values ('" + txt_musteri_adi.Text + "','" + txt_musteri_soyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda1002_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "1002";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1002 (Adi,Soyadi) values ('" + txt_musteri_adi.Text + "','" + txt_musteri_soyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda1003_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "1003";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1003 (Adi,Soyadi) values ('" + txt_musteri_adi.Text + "','" + txt_musteri_soyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda1004_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "1004";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1004 (Adi,Soyadi) values ('" + txt_musteri_adi.Text + "','" + txt_musteri_soyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda1005_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "1005";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1005 (Adi,Soyadi) values ('" + txt_musteri_adi.Text + "','" + txt_musteri_soyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda1006_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "1006";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1006 (Adi,Soyadi) values ('" + txt_musteri_adi.Text + "','" + txt_musteri_soyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda1007_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "1007";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1007 (Adi,Soyadi) values ('" + txt_musteri_adi.Text + "','" + txt_musteri_soyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda1008_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "1008";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1008 (Adi,Soyadi) values ('" + txt_musteri_adi.Text + "','" + txt_musteri_soyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda2001_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "2001";
        }

        private void btnOda2002_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "2002";
        }

        private void btnOda2003_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "2003";
        }

        private void btnOda2004_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "2004";
        }

        private void btnOda2005_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "2005";
        }

        private void btnOda2006_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "2006";
        }

        private void btnOda2007_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "2007";
        }

        private void btnOda2008_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "2008";
        }

        private void btnOda3001_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "3001";
        }

        private void btnOda3002_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "3002";
        }

        private void btnOda3003_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "3003";
        }

        private void btnOda3004_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "3004";
        }

        private void btnOda3005_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "3005";
        }

        private void btnOda3006_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "3006";
        }

        private void btnOda3007_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "3007";
        }

        private void btnOda3008_Click(object sender, EventArgs e)
        {
            txt_oda_no.Text = "3008";
        }

        private void dtp_cikis_tarihi_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime girisTarihi = Convert.ToDateTime(dtp_giris_tarihi.Text);
            DateTime cikisTarihi = Convert.ToDateTime(dtp_cikis_tarihi.Text);

            TimeSpan Sonuc = cikisTarihi - girisTarihi;

            txt_Fiyat.Text = (Sonuc.TotalDays * 150).ToString();

            lbl_toplam_gün.Text = Sonuc.TotalDays.ToString();


        }

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Oda1001", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                btnOda1001.Text = oku["Adi"].ToString() + "  " + oku["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda1001.Text != "1001")
            {
                btnOda1001.BackColor = Color.Red;
                btnOda1001.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda1002", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnOda1002.Text = oku2["Adi"].ToString() + "  " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda1002.Text != "1002")
            {
                btnOda1002.BackColor = Color.Red;
                    btnOda1002.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda1003", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnOda1003.Text = oku3["Adi"].ToString() + "  " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda1003.Text != "1003")
            {
                btnOda1003.BackColor = Color.Red;
                btnOda1003.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda1004", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnOda1004.Text = oku4["Adi"].ToString() + "  " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda1004.Text != "1004")
            {
                btnOda1004.BackColor = Color.Red;
                btnOda1004.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda1005", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnOda1005.Text = oku5["Adi"].ToString() + "  " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda1005.Text != "1005")
            {
                btnOda1005.BackColor = Color.Red;
                btnOda1005.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda1006", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnOda1006.Text = oku6["Adi"].ToString() + "  " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda1006.Text != "1006")
            {
                btnOda1006.BackColor = Color.Red;
                btnOda1006.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda1007", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnOda1007.Text = oku7["Adi"].ToString() + "  " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda1007.Text != "1007")
            {
                btnOda1007.BackColor = Color.Red;
                btnOda1007.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda1008", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnOda1008.Text = oku8["Adi"].ToString() + "  " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda1008.Text != "1008")
            {
                btnOda1008.BackColor = Color.Red;
                btnOda1008.Enabled = false;
            }
        }

        private void btn_musteri_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriTable (MusteriAd,MusteriSoyad,MusteriTc,MusteriTelNo,MusteriMail,MusteriOdaNo,MusteriCinsiyet,MusteriUcret) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);

            komut.Parameters.AddWithValue("@p1", txt_musteri_adi.Text);
            komut.Parameters.AddWithValue("@p2", txt_musteri_soyadi.Text);
            komut.Parameters.AddWithValue("@p3", msk_tc_no.Text);
            komut.Parameters.AddWithValue("@p4", msk_tel_no.Text);
            komut.Parameters.AddWithValue("@p5", txt_email.Text);
            komut.Parameters.AddWithValue("@p6", txt_oda_no.Text);
            komut.Parameters.AddWithValue("@p7", cmb_cinsiyet.Text);
            komut.Parameters.AddWithValue("@p8", txt_Fiyat.Text);
            komut.Parameters.AddWithValue("@p9", dtp_giris_tarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@p10", dtp_cikis_tarihi.Value.ToString("yyyy-MM-dd"));

            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
