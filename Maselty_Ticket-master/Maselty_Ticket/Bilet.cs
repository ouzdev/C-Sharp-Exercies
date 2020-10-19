using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maselty_Ticket
{
    public class Bilet
    {
        public string salonismi;
        public string filmismi;
        public int koltuksayisi;
        public int boskoltuksayisi;
        public int dolu_koltuk;
        public string satis_maliyeti = "20";
        public int indirimli_satis_adedi;
        public int normal_satis_adedi;

        public bool satis = false;

        public int Hasilat()
        {
          int indirimli=  indirimli_satis_adedi * 10;
            int normal = normal_satis_adedi * 15;

            int sonuc = indirimli + normal;
            return sonuc;
        }
    }
}
