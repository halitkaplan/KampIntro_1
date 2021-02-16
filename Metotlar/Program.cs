using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun(); //class içerisinden bir değişken tanımlayaağımız zaman, bunu newlememiz gerekiyor.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)      // Urun yerine var yazsam da olur, program bunu arka planda Urun olarak görüyor zaten
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("------------------Metodlar-------------------");


            SepetManager sepetManager = new SepetManager(); //instance - class örneği oluşturduk.
            //encapsulation
            sepetManager.Ekle(urun1); //metodu bu şekilde çağırıyorum.
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            // Ekleme işlemini bu şekilde yapılabilir mi. Tamam yaptık diyelim, adam geldi dedi ki, hocam ben stok adedini de göstermek isityorum.
            // ya da gösterdiğim şeylerden bazılarının artık gösterilmemesini istiyorum. O zman gidiyor Ekle2 ye, Stok adedini de ekleyince, 
            // bu ekleme işlemini yaptığım tüm sayfalar patlayacak. Her birindeki veriyi değiştirmem, düzeltmem, eklemem gerekiyor.
            // bu olaya da encapsulation deniyor.  bu şekilde yapmamak daha mantıklı ve sağlıklı. 

            // ayrı ayrı olacak düzensiz bir yapıyı kapsül içerisine sokmamız gerekiyor. düzenlememiz gerekiyor yani.







        }
    }
}


// Metotlar bize, tekrar tekrar kulanılabilirliği sunuyor.
// Kendimizi tekrar edeceğimiz kod blokarımız varsa eğer, 
// metot şeklinde onları yazabiliriz.
// Doğru şekilde yazılması gerekiyor tabiiki.

