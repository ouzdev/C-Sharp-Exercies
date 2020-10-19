using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo
{
    public delegate void StokKontrol();

    public class Urun
    {
        private int _stok;

        public Urun(int stok)
        {
            _stok = stok;
        }

        public event StokKontrol StokKontrolEvent;
        public string StokAdı { get; set; }
        public int StokSayisi
        {
            get { return _stok; }


            set
            {
                _stok = value;

                if (value<=15 && StokKontrolEvent!=null)
                {
                    StokKontrolEvent();
                }

            }
        }

        public void Satis(int adet)
        {
            StokSayisi -= adet;
            Console.WriteLine("Ürün Adı:{0} Stok Adedi : {1}", _stok,StokAdı);
        }
    }
}
