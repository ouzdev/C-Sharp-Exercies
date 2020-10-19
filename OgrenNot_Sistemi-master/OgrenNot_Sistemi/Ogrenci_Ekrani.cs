using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenNot_Sistemi
{
    public partial class Ogrenci_Ekrani : Form
    {
        public Ogrenci_Ekrani()
        {
            InitializeComponent();
        }
        //Data Source=.\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True
        public string numara;

        //bAĞLANTİMİ KURDUM
        SqlConnection baglanti_adresi = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");


        private void Ogrenci_Ekrani_Load(object sender, EventArgs e)
        {
            lbl_ogrenci_numara.Text = numara;

            //AD VE SOYAD KISIMLARINI VERİTABANINDAN ALICAM. 30.12.2019 TARİHİ4
            baglanti_adresi.Open();
            SqlCommand komut = new SqlCommand("Select* From DersTable where OgrenciNo=@p1", baglanti_adresi);

            komut.Parameters.AddWithValue("@p1", numara);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lbl_ogrenci_adsoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lbl_ogrenci_numara.Text = dr[1].ToString();
                lbl_birinci_sinav.Text = dr[4].ToString();
                lbl_ikinci_sinav.Text = dr[5].ToString();
                lbl_ucuncu_sinav.Text = dr[6].ToString();
                lbl_ortalama.Text = dr[7].ToString();
                lbl_durum.Text = dr[8].ToString();
                if (lbl_durum.Text=="True")
                {
                    lbl_durum.Text = "Geçtiniz";
                }
                else
                {
                    lbl_durum.Text = "Malesef Kaldınız Geçmiş Olsun..a";
                }
                
            }
            baglanti_adresi.Close();
        }
    }
}
