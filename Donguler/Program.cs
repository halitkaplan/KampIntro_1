using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // bu tip verileri, array (dizi) lerde tutarız.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programaya başlangıç için temel kurs", "Java", "Python", "C++"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }




            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");

        }
    }
}
