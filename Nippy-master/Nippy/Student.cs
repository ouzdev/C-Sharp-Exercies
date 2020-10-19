using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippy
{
    public class Student
    {
        public string OgrenciNo;
        public string OgrenciAdı;
        public string OgrenciSoyadi;
        public string Devamsizlik = "0";
        public bool Aidat = true;

        public Student(string ogrenciNo,string ogrenciAd, string ogrenciSoyad)
        {
            this.OgrenciNo = ogrenciNo;
            this.OgrenciAdı = ogrenciAd;
            this.OgrenciSoyadi = ogrenciSoyad;
           

        }
        public Student()
        {
          

        }
    }
}
