using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenNot_Sistemi
{
    public partial class Egitmen_Ekrani : Form
    {
        public Egitmen_Ekrani()
        {
            InitializeComponent();
        }
        int kalan = 0;
        int gecen = 0;
        SqlConnection baglanti_adresi = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void Egitmen_Ekrani_Load(object sender, EventArgs e)
        {
            btn_not_ekle.Enabled = false;
            baglanti_adresi.Open();
            SqlCommand komut1 = new SqlCommand("SELECT (DURUM) FROM DersTable", baglanti_adresi);
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.DersTable' table. You can move, or remove it, as needed.
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == "True")
                {
                    gecen++;
                }
                else
                {
                    kalan++;
                }


            }
            lbl_gecen_sayisi.Text = gecen.ToString();
            lbl_kalan_sayisi.Text = kalan.ToString();
            this.dersTableTableAdapter.Fill(this.dbNotKayitDataSet.DersTable);

        }

        private void btn_ogrenci_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti_adresi = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");

            baglanti_adresi.Open();

            SqlCommand komut = new SqlCommand("insert into DersTable (OgrenciNo,OgrenciAd,OgrenciSoyad) values(@p1,@p2,@p3)", baglanti_adresi);
            komut.Parameters.AddWithValue("@p1", msk_ogrenci_mumara.Text);
            komut.Parameters.AddWithValue("@p2", txt_ogrenci_ad.Text);
            komut.Parameters.AddWithValue("@p3", txt_ogrenci_soyad.Text);
            komut.ExecuteNonQuery();
            baglanti_adresi.Close();
            this.dersTableTableAdapter.Fill(this.dbNotKayitDataSet.DersTable);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            txt_ogrenci_ad.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txt_ogrenci_soyad.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            msk_ogrenci_mumara.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txt_birinci_sinav_notu.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txt_ikinci_sinav_notu.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txt_ucuncu_sinav_notu.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            btn_not_ekle.Enabled = true;
        }

        private void btn_not_ekle_Click(object sender, EventArgs e)
        {
            string durum;
           
            double s1 = Convert.ToDouble(txt_birinci_sinav_notu.Text);
            double s2 = Convert.ToDouble(txt_ikinci_sinav_notu.Text);
            double s3 = Convert.ToDouble(txt_ucuncu_sinav_notu.Text);

            double ortalama = (s1 + s2 + s3) / 3;
            if (ortalama <= 50)
            {
                durum = "False";
            }
            else
            {
                durum = "True";
            }
            lbl_sinif_ortalama.Text = ortalama.ToString();
            SqlConnection baglanti_adresi = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");

            baglanti_adresi.Open();
            SqlCommand komut1 = new SqlCommand("SELECT (DURUM) FROM DersTable", baglanti_adresi);
            SqlCommand komut = new SqlCommand("update DersTable set OgrenciSinav1=@p1,OgrenciSinav2=@p2,OgrenciSinav3=@p3,ORTALAMA=@p4,DURUM=@p5 where OgrenciNo=@p6", baglanti_adresi);
            komut.Parameters.AddWithValue("@p1", txt_birinci_sinav_notu.Text);
            komut.Parameters.AddWithValue("@p2", txt_ikinci_sinav_notu.Text);
            komut.Parameters.AddWithValue("@p3", txt_ucuncu_sinav_notu.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lbl_sinif_ortalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", msk_ogrenci_mumara.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString()=="True")
                {
                    gecen++;
                }
                else
                {
                    kalan++;
                }
           
             
            }
            lbl_gecen_sayisi.Text = gecen.ToString();
            lbl_kalan_sayisi.Text = kalan.ToString();

            this.dersTableTableAdapter.Fill(this.dbNotKayitDataSet.DersTable);
            baglanti_adresi.Close();



            btn_not_ekle.Enabled = false;

        }
    }
}
