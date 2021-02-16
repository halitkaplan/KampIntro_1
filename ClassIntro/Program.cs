using System;

namespace ClassIntro
{

    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Egin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Halit Kaplan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            // ben, string gibi, int gibi bir veri tipi oluşturdum diyebilirim. string bir ifade yapsaydım, arrayim ...
            // string array olacaktı. Fakat, ben Kurs diye bir veri tipi oluşturduğum ve bunu da array şeklinde yazmak istediğimdem ...
            // Array tipimde 'Kurs' veri tipinde olacak. 
            // Aşağıda, Kurs veri tipinin hangi değişkenleri olduğunu yazdık.
            // tek tek Console.WriteLine yapıp, kursları yazdırmak yerine, bu olupşturduğumuz diziyi dönelim.


            foreach (var kurs in kurslar) // buradaki kurs takma isimdir. // 'var' veri tipini verebiliriz. 'Kurs' olarakta verebiliriz.
            {
                // Console.WriteLine(kurs.KursAdi); // tüm kursların isimlerini yazdıracak.
                // kurslar dizisindeki tüm kursları dönüyor. (kurs1,kurs2, kurs3) ve bu kursların isimlerini 
                // burada yazdırıyor. araya boşluk koyup, kursun eğitmenini de yazdıralım.

                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);

            }

            //Console.WriteLine("Hello World!");
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

        //kurs un 3 tane değişkeni var.

    }
}
