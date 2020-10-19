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
    public partial class BellWood_Hotel_Odalar : Form
    {
        public BellWood_Hotel_Odalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TG57B21\SQLEXPRESS;Initial Catalog=BellWoodHotels;Integrated Security=True");

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void BellWood_Hotel_Odalar_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Oda1001",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                btn_1001.Text = oku["Adi"].ToString() + "  " + oku["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn_1001.Text != "1001")
            {
                btn_1001.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda1002", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btn_1002.Text = oku2["Adi"].ToString() + "  " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn_1002.Text != "1002")
            {
                btn_1002.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda1003", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btn_1003.Text = oku3["Adi"].ToString() + "  " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn_1003.Text != "1003")
            {
                btn_1003.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda1004", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btn_1004.Text = oku4["Adi"].ToString() + "  " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn_1004.Text != "1004")
            {
                btn_1004.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda1005", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btn_1005.Text = oku5["Adi"].ToString() + "  " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn_1005.Text != "1005")
            {
                btn_1005.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda1006", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btn_1006.Text = oku6["Adi"].ToString() + "  " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn_1006.Text != "1006")
            {
                btn_1006.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda1007", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btn_1007.Text = oku7["Adi"].ToString() + "  " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            
            if (btn_1007.Text != "1007")
            {
                btn_1007.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda1008", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btn_1008.Text = oku8["Adi"].ToString() + "  " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn_1008.Text != "1008")
            {
                btn_1008.BackColor = Color.Red;
            }
        }
    }
}
