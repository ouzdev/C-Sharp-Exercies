using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCiftlik
{
    public class Hayvan
    {
        public string ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string HayvanTuru { get; set; }
        public string HayvanResimUrl { get; set; }
        public int MahsulUretim { get; set; }

        public int AclikDurumu { get; set; }
        public int YemTuketim { get; set; }

    }
}
