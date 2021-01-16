using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;

            double faizOranı = 1.45;

            bool sistemeGirisYapmismi = false;



            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("eşittir");

            }

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Ayarlar");

            }
            else
            {
                Console.WriteLine("Giriş yap la");
            }


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);





        }
    }
}
