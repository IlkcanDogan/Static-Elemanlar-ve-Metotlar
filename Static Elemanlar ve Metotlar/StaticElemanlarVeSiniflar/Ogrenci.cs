using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticElemanlarVeSiniflar
{
    class Ogrenci
    {
        public static int ogrenciSayisi = 0;

        public string adiSoyadi;
        public int numara;

        public Ogrenci()
        {
            ogrenciSayisi++;
        }
    }
}
