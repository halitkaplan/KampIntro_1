using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety= tip güvenliği 
            // yani biz, bir şey yanımlarken, onun veri tipini tanımlamak zorundayız.
            // do not repeat yourself 
            string kategoriEtiketi = "Kategoriler";

            int ogrenciSayisi = 32000;

            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);



        }
    }
}
