using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellWood_Hotel_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TG57B21\SQLEXPRESS;Initial Catalog=BellWoodHotels;Integrated Security=True");
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sql = "Select * From Admin WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifresi";
                SqlParameter parametre1 = new SqlParameter("KullaniciAdi",txt_kullanici_adi.Text.Trim());
                SqlParameter parametre2 = new SqlParameter("Sifresi", txt_sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(parametre1);
                komut.Parameters.Add(parametre2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    BellWood_AnaMenu frm = new BellWood_AnaMenu();
                    frm.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
