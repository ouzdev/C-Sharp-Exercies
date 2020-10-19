using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nippy
{
    public partial class Detay_Formu : Form
    {
        Student ogrenci = new Student();
        Detay dty = new Detay();
        public Detay_Formu(Student ogr,Detay dty)
        {
            ogrenci = ogr;
            this.dty = dty;
            InitializeComponent();
        }



        private void Detay_Formu_Load(object sender, EventArgs e)
        {
            lbl_ogrenci_ad_soyad.Text=ogrenci.OgrenciAdı+" "+ogrenci.OgrenciSoyadi;
            lbl_veli_ad_soyad.Text = dty.veliAdSoyad;
            lbl_adres.Text = dty.adres;
            lbl_telefon.Text = dty.telefon;
        }
    }
}
