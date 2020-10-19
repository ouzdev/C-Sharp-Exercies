using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turkish_Idendity_Card
{
    public class Kisi
    {
        public string _tcNo;
        private string _ad;
        private string _soyad;
        private string _dogumyili;
        private string _cinsiyet;
        private string _serino;
        private string _anneadi;
        private string _babaadi;
        private string _annekizliksoyadi;

        public Kisi()
        {
            _tcNo = "00000000000";
        }
       

        public string TcNo
        {

            get
            {
                return _tcNo;
            }
            private set
            {
                if (value.Length == 11)
                {
                    string key = value;
                    bool kontrol = true;
                    foreach (Char item in value)
                    {
                        if (char.IsNumber(item) == false)
                        {
                            kontrol = false;
                            break;
                        }

                    }
                    string hata = "HATALI TC NO";
                    if (kontrol)
                    {
                        _tcNo = value;

                    }
                    else
                    {
                        _tcNo = hata;
                    }
                }
                else
                {
                    string hata = "Karakter uzunluğu 11 hane olmalıdır.";
                    _tcNo = hata;
                }

            }


        }
        public string Ad { get { return _ad; } set { _ad = value.ToUpper(); } }
        public string Soyad { get { return _soyad; } set { _soyad = value.ToUpper(); } }
        public string DogumYili { get { return _dogumyili; } set { _dogumyili = value; } }
        public string Cinsiyet { get { return _cinsiyet; } set { _cinsiyet = value; } }
        public string SeriNo
        {
            get
            {
                return _serino;
            }

            set
            {
                if (value.Length == 9)
                {
                    _serino = value;
                }
                else
                {
                    string hata = "Seri No 9 Karakter Olmalıdır.";
                    _serino = hata;
                }
            }
        }
        public string BabaAdi { get { return _babaadi; } set { _babaadi = value.ToUpper(); } }
        public string AnneAdi { get { return _anneadi; } set { _anneadi = value.ToUpper(); } }
        public string AnneKizlikSoyadi { get { return _annekizliksoyadi; } set { _annekizliksoyadi = value.ToUpper(); } }

    }
}
