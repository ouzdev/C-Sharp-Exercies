using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellWood_Hotel_Otomasyon
{
    public partial class BellWood_AnaMenu : Form
    {
        public BellWood_AnaMenu()
        {
            InitializeComponent();
        }

        private void btn_admin_giris_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btn_yeni_musteri_ekle_Click(object sender, EventArgs e)
        {
            MusteriEkrani customerScreen = new MusteriEkrani();
            customerScreen.Show();
            this.Hide();
        }

        private void btn_odalar_Click(object sender, EventArgs e)
        {
            BellWood_Hotel_Odalar bellWood_Rooms = new BellWood_Hotel_Odalar();
            bellWood_Rooms.Show();
            this.Hide();
        }

        private void btn_musteri_liste_Click(object sender, EventArgs e)
        {
            Musteriler customer_list = new Musteriler();
            customer_list.Show();
            this.Hide();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BellWood Hotels | FloryaSoft 2020 | www.floryasoft.com");
        }

    
    }
}
