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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=SecimSenDB; integrated security=true");

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into BolgeTBL (BolgeAd,AToplulugu,BToplulugu,CToplulugu,DToplulugu,EToplulugu) values(@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", txt_bolge.Text);
            komut.Parameters.AddWithValue("@P2", txt_a_oy_sayisi.Text);
            komut.Parameters.AddWithValue("@P3", txt_b_oy_sayisi.Text);
            komut.Parameters.AddWithValue("@P4", txt_c_oy_sayisi.Text);
            komut.Parameters.AddWithValue("@P5", txt_d_oy_sayisi.Text);
            komut.Parameters.AddWithValue("@P6", txt_e_oy_sayisi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt işlemi başarılı.");



        }

        private void btn_istatislik_Click(object sender, EventArgs e)
        {
            Istatislik frm = new Istatislik();
            frm.Show();
        }
    }
}
