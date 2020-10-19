using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun telefon = new Urun(50);
            telefon.StokAdı = "Samsung Galaxy S6";

            Urun bilgisayar = new Urun(50);
            bilgisayar.StokAdı = "Monster Abra A5 V9.2";
            bilgisayar.StokKontrolEvent += Bilgisayar_StokKontrolEvent;

            for (int i = 0; i < 10; i++)
            {
                bilgisayar.Satis(10);
                telefon.Satis(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Bilgisayar_StokKontrolEvent()
        {
            Console.WriteLine("Bilgisayar Stoğu Tükendi...");
        }
    }
}
