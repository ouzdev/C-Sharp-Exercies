using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maselty_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Bilet> bilet = new List<Bilet>();
        public Bilet blt;

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            blt = new Bilet();
            {

                blt.salonismi = txt_SalonIsmi.Text;
                blt.filmismi = txt_filmIsmi.Text;
                blt.koltuksayisi = Convert.ToInt32(txt_koltukSayisi.Text);

            }

            bilet.Add(blt);
            cmb_filmsec.Items.Clear();
            foreach (Bilet eleman in bilet)
            {

                cmb_filmsec.Items.Add(eleman.filmismi);
            }

            txt_filmIsmi.Clear();
            txt_koltukSayisi.Clear();
            txt_SalonIsmi.Clear();
            cmb_salonsec.Items.Clear();
        }

        private void chk_mevcut_salon_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_mevcut_salon.Checked)
            {
                txt_SalonIsmi.Enabled = false;
                cmb_salonsec.Enabled = true;
                txt_filmIsmi.Clear();
                txt_koltukSayisi.Clear();
                txt_SalonIsmi.Clear();
                cmb_salonsec.Items.Clear();

                foreach (Bilet eleman in bilet)
                {

                    cmb_salonsec.Items.Add(eleman.salonismi);


                }
            }
            else
            {
                txt_filmIsmi.Clear();
                txt_koltukSayisi.Clear();
                txt_SalonIsmi.Clear();
                cmb_salonsec.Items.Clear();
                txt_SalonIsmi.Enabled = true;
                cmb_salonsec.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_salonsec.Enabled = false;
        }

        private void cmb_salonsec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aranan_kelime = cmb_salonsec.SelectedItem.ToString();
            txt_filmIsmi.Clear();
            txt_koltukSayisi.Clear();
            txt_SalonIsmi.Clear();
            cmb_salonsec.Items.Clear();


            foreach (Bilet eleman in bilet)
            {
                cmb_salonsec.Items.Add(eleman.salonismi);

                if (aranan_kelime == eleman.salonismi)
                {
                    txt_filmIsmi.Text = eleman.filmismi;
                    txt_koltukSayisi.Text = eleman.koltuksayisi.ToString();
                    txt_SalonIsmi.Text = eleman.salonismi;
                }




            }
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            string degisecek_salon_film_bilgisi = txt_SalonIsmi.Text;

            foreach (Bilet eleman in bilet)
            {
                if (eleman.salonismi == degisecek_salon_film_bilgisi)
                {
                    eleman.filmismi = txt_filmIsmi.Text;
                    eleman.koltuksayisi = Convert.ToInt32(txt_koltukSayisi.Text);
                    cmb_salonsec.Items.Clear();
                }
            }
            foreach (Bilet eleman in bilet)
            {
                cmb_salonsec.Items.Add(eleman.salonismi);
            }
        }
     
        private void btn_satis_Click(object sender, EventArgs e)
        {
            string arana_film = cmb_filmsec.SelectedItem.ToString();
          
            foreach (Bilet eleman in bilet)
            {
                if (eleman.filmismi == arana_film)
                {
                    if (eleman.boskoltuksayisi==0)
                    {
                        MessageBox.Show("Boş koltuk olmadığı için satış yapamzsınız.");
                        btn_satis.Enabled = false;
                    }
                    else
                    {
                        if (chk_indirimli.Checked)
                        {
                            eleman.satis = true;
                            eleman.indirimli_satis_adedi++;
                        }
                        else
                        {
                            eleman.normal_satis_adedi++;
                        }

                        eleman.dolu_koltuk++;
                        eleman.boskoltuksayisi = eleman.koltuksayisi - eleman.dolu_koltuk;
                    }

                    


                }
            }



        }

        private void btn_hasilat_Click(object sender, EventArgs e)
        {
            string arana_film = cmb_filmsec.SelectedItem.ToString();
            foreach (Bilet eleman in bilet)
            {
                if (eleman.filmismi==arana_film)
                {
                    blt = eleman;
                }
            }
            MessageBox.Show("Toplam Hasılat :" + blt.Hasilat().ToString()); 
        }

        private void btn_boskoltuk_Click(object sender, EventArgs e)
        {
            string arana_film = cmb_filmsec.SelectedItem.ToString();
            foreach (Bilet eleman in bilet)
            {
                if (eleman.filmismi == arana_film)
                {
                    blt = eleman;
                }
            }
            MessageBox.Show("Boş Koltuk Sayısı :" + blt.boskoltuksayisi.ToString());
        }
    }
}
