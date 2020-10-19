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

namespace SecimSen_Istatislik_Programi
{
    public partial class Istatislik : Form
    {
        public Istatislik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=SecimSenDB; integrated security=true");
        private void Istatislik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select (BolgeAd) from BolgeTBL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cmb_bolgesec.Items.Add(dr[0]);
            }
            baglanti.Close();
            // Toplulukların oy oranlarını charta yazdırma
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select SUM(AToplulugu),SUM(BToplulugu),SUM(CToplulugu),SUM(DToplulugu),SUM(EToplulugu) from BolgeTBL", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                chartPartiler.Series["Topluluklar"].Points.AddXY("A Topluluğu", dr2[0]);
                chartPartiler.Series["Topluluklar"].Points.AddXY("B Topluluğu", dr2[1]);
                chartPartiler.Series["Topluluklar"].Points.AddXY("C Topluluğu", dr2[2]);
                chartPartiler.Series["Topluluklar"].Points.AddXY("D Topluluğu", dr2[3]);
                chartPartiler.Series["Topluluklar"].Points.AddXY("E Topluluğu", dr2[4]);
            }

            baglanti.Close();
        }

        private void cmb_bolgesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from BolgeTBL where BolgeAd=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", cmb_bolgesec.Text);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                pbar_atoplulugu.Value =int.Parse(dr[2].ToString());
                pbar_btoplulugu.Value = int.Parse(dr[3].ToString());
                pbar_ctoplulugu.Value = int.Parse(dr[4].ToString());
                pbar_dtoplulugu.Value = int.Parse(dr[5].ToString());
                pbar_etoplulugu.Value = int.Parse(dr[6].ToString());

                lbl_a.Text = dr[2].ToString();
                lbl_b.Text = dr[3].ToString();
                lbl_c.Text = dr[4].ToString();
                lbl_d.Text = dr[5].ToString();
                lbl_e.Text = dr[6].ToString();



            }
            baglanti.Close();
        }
    }
}
