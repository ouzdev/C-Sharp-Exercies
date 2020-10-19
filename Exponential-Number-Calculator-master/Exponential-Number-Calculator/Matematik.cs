using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponential_Number_Calculator
{
    public class Matematik
    {
        // Uslu tipinde geri değer döndüren bir metod oluşturdum. Bu metodun geri dönüş değerleri taban ve üs olacak.
        //Metod parametre olarak Uslu tipinde 2 adet parametre alıyor.
        public Uslu Hesapla(Uslu sayi1, Uslu sayi2)
        {
            //Hesaplanan yeni değerleri tutmak için gecici adında Uslu tipinde yeni bir nesne oluşturdum.
            //Bu nesneyi kullanarak hesaplanan yeni değerleri forma göndericem.
            Uslu gecici = new Uslu();

            // Eğer tabanlar eşit ise usleri toplayıp return edicem.
            if (sayi1.taban == sayi2.taban)
            {
                int sonuc = sayi1.us + sayi2.us;
                gecici.us = sonuc;
                gecici.taban = sayi1.taban;
                return gecici;
            }
            // Tabanlar eşit değilse üsleri çarpıp değerleri geriye return edicem.
            else
            {
                int sonuc = sayi1.taban * sayi2.taban;
                gecici.taban = sonuc;
                //Usler zaten eşitti yani sayi1 veya sayi2 nin üsleri eşit olduğu için herhangi birinin üssünü gecici nesneme aktarıyorum.
                gecici.us = sayi1.us;
                return gecici;

            }

        }
    }
}
