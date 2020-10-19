using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BellWood_Hotel_Otomasyon
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TG57B21\SQLEXPRESS;Initial Catalog=BellWoodHotels;Integrated Security=True");

        private void musteriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriTable",baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem listView = new ListViewItem();

                listView.Text = dr["MusteriId"].ToString();
                listView.SubItems.Add(dr["MusteriAd"].ToString());
                listView.SubItems.Add(dr["MusteriSoyad"].ToString());
                listView.SubItems.Add(dr["MusteriTelNo"].ToString());
                listView.SubItems.Add(dr["MusteriTc"].ToString());
                listView.SubItems.Add(dr["MusteriMail"].ToString());
                
                listView.SubItems.Add(dr["MusteriOdaNo"].ToString());
                listView.SubItems.Add(dr["MusteriCinsiyet"].ToString());
                listView.SubItems.Add(dr["MusteriUcret"].ToString());
                listView.SubItems.Add(dr["GirisTarihi"].ToString());
                listView.SubItems.Add(dr["CikisTarihi"].ToString());

                listView1.Items.Add(listView);

            }
          
            baglanti.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            musteriGoster();
        }
        int index = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            index = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            txt_musteri_adi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txt_musteri_soyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            msk_tel_no.Text= listView1.SelectedItems[0].SubItems[3].Text;
            msk_tc_no.Text= listView1.SelectedItems[0].SubItems[4].Text;
            txt_email.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txt_oda_no.Text = listView1.SelectedItems[0].SubItems[6].Text;
            cmb_cinsiyet.Text = listView1.SelectedItems[0].SubItems[7].Text;

            txt_Fiyat.Text = listView1.SelectedItems[0].SubItems[8].Text;           
            dtp_giris_tarihi.Text= listView1.SelectedItems[0].SubItems[9].Text;
            dtp_cikis_tarihi.Text= listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btn_musteri_sil_Click(object sender, EventArgs e)
        {
            if (txt_oda_no.Text=="1001")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Oda1001", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                musteriGoster();
            }
            if (txt_oda_no.Text == "1002")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Oda1002", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                musteriGoster();
            }
            if (txt_oda_no.Text == "1003")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Oda1003", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                musteriGoster();
            }
            if (txt_oda_no.Text == "1004")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Oda1004", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                musteriGoster();
            }
            if (txt_oda_no.Text == "1005")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Oda1005", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                musteriGoster();
            }
            if (txt_oda_no.Text == "1006")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Oda1006", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                musteriGoster();
            }
            if (txt_oda_no.Text == "1007")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Oda1007", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                musteriGoster();
            }
            if (txt_oda_no.Text == "1008")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Oda1008", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                musteriGoster();
            }

            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("delete from MusteriTable where (MusteriId=@p1)", baglanti);
            komut1.Parameters.AddWithValue("@p1", index);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            musteriGoster();


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_musteri_adi.Clear();
            txt_musteri_soyadi.Clear();
            txt_Fiyat.Clear();
            txt_email.Clear();
            txt_oda_no.Clear();
            msk_tc_no.Clear();
            msk_tel_no.Clear();
            
        }

        private void btn_musteri_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriTable set MusteriAd=@p1,MusteriSoyad=@p2,MusteriTc=@p3,MusteriTelNo=@p4,MusteriMail=@p5,MusteriOdaNo=@p6,MusteriCinsiyet=@p7,MusteriUcret=@p8,GirisTarihi=@p9,CikisTarihi=@p10 where MusteriId="+index+"",baglanti);

            komut.Parameters.AddWithValue("@p1",txt_musteri_adi.Text);
            komut.Parameters.AddWithValue("@p2",txt_musteri_soyadi.Text);
            komut.Parameters.AddWithValue("@p3",msk_tc_no.Text);
            komut.Parameters.AddWithValue("@p4",msk_tel_no.Text);
            komut.Parameters.AddWithValue("@p5",txt_email.Text);
            komut.Parameters.AddWithValue("@p6",txt_oda_no.Text);
            komut.Parameters.AddWithValue("@p7",cmb_cinsiyet.Text);
            komut.Parameters.AddWithValue("@p8",txt_Fiyat.Text);
            komut.Parameters.AddWithValue("@p9",dtp_giris_tarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@p10",dtp_cikis_tarihi.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            baglanti.Close();
            musteriGoster();
         
        }

        private void btn_musteri_ara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriTable where MusteriAd like '%"+txt_musteri_ara.Text+"%'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem listView = new ListViewItem();

                listView.Text = dr["MusteriId"].ToString();
                listView.SubItems.Add(dr["MusteriAd"].ToString());
                listView.SubItems.Add(dr["MusteriSoyad"].ToString());
                listView.SubItems.Add(dr["MusteriTelNo"].ToString());
                listView.SubItems.Add(dr["MusteriTc"].ToString());
                listView.SubItems.Add(dr["MusteriMail"].ToString());

                listView.SubItems.Add(dr["MusteriOdaNo"].ToString());
                listView.SubItems.Add(dr["MusteriCinsiyet"].ToString());
                listView.SubItems.Add(dr["MusteriUcret"].ToString());
                listView.SubItems.Add(dr["GirisTarihi"].ToString());
                listView.SubItems.Add(dr["CikisTarihi"].ToString());

                listView1.Items.Add(listView);

            }

            baglanti.Close();

        }
    }
}


