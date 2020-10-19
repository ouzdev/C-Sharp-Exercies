using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenNot_Sistemi
{
    public partial class Giris_Ekrani : Form
    {
        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Ogrenci_Ekrani ogr_screen = new Ogrenci_Ekrani();
            ogr_screen.numara = msk_ogrenci_numara.Text;
            ogr_screen.Show();

          

        }

        private void msk_ogrenci_numara_TextChanged(object sender, EventArgs e)
        {
            if (msk_ogrenci_numara.Text=="1111")
            {
                Egitmen_Ekrani instructor_screen = new Egitmen_Ekrani();
                instructor_screen.Show();
            }
        }
    }
}
