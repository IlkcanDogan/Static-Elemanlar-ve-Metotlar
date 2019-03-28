using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticElemanlarVeSiniflar
{
    class Program
    {
        /*
         * Bir sınıf içerisindeki static olmayan metotlara ve özelliklere o sınıftan
         * oluşturduğumuz nesneler üzerinden erişiriz.
         * 
         * Static olan metotlara ve özelliklere ise nesne oluşturmadan sınıf adı ile erişiriz.
         * 
         * Static olmayan elemanlar nesneye özgü bilgileri tutarken static olan elemanlar
         * uygulama çalıştığı sürece kendilerine en son atanan değeri tutarlar. "adiSoyadi" ve
         * "numara" değişkenleri static olmadığı için "Ogrenci" sınıfından oluşturulan her bir
         * nesne için farklı değerler tutabilir. "ogrenciSayisi" değişkeni static olduğu için
         * kendisine en son atanan değeri tutacaktır.
         * ------------------------------------------------------------------------------------
         * Bir özelliği veya metodu static yapmak için erişim belirleyicisinden sonra "static"
         * anahtar kelimesini getirmemiz gerekir.
         * 
         * [Erişim Belirleyicisi] static [Veri Tipi] [Özellik Adı];
         * public static int TamSayi;
         * 
         * [Erişim Belirleyicisi] static [Geri Dönüş Değerinin Tipi] [Metot Adı] (Parametreler){}
         * public static void Bilgi(){}
         * ------------------------------------------------------------------------------------
         * Static bir metodun içerisinden static olmayan metotlar ve değişkenler çağrılamaz.
         * Sadece diğer static metotlar ve değişkenler çağırılabilir.
         * 
         * DOĞRU
         * Public static void metot1() {/Gövde/}
         * Public static void metor2() { metot1; }
         * 
         * YANLIŞ
         * Public void metot1() {/Gövde/}
         * Public static void metor2() { metot1; }
         * ------------------------------------------------------------------------------------
         */
        static void Main(string[] args)
        {
            //Static elemanlara sınıf adı ile erişilir.
            //Ogrenci sayisi: 0
            Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.ogrenciSayisi);

            //Static olmayan elemanlara nesne oluşturularak erişilir.
            Ogrenci ogr1 = new Ogrenci();
            ogr1.adiSoyadi = "ilkcan doğan";
            ogr1.numara = 444;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.adiSoyadi = "Berk Ayyıldız";
            ogr2.numara = 111;

            //Öğrenci sayısı: 2
            Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.ogrenciSayisi);

            Console.ReadLine();

        }
    }
}
