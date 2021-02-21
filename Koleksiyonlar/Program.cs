using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //______________________________________________________________________________________

            // 1-> string olarak dizimi oluşturdum ve içerisinde 4 tane eleman girdim.
            // 2-> alt satırlarında da bu elemanların adını 0. eleman, 1. eleman ... diye yazıdırdım.
            // 3-> Çok güzel. 
            // 4-> Peki, ben bu diziye eleman eklemek istediğim zaman aklıma gelem ilk yol:
            //          isimler[4] = "İlker";
            //          Console.WriteLine(isimler[4]);
            // 5-> yazmak oluyor. 
            // 6-> Bu şekilde yazdığımda programın patladığını görebilirim. Çünkü: 
            // 7-> yukarıda oluşturmuş olduğum dizi 4 elemanlık bir dizi. Ve ben burada 5. bir elemanı set ettirmeye çalışıyorum.
            // 8-> Dizi sınırlarını aşıyor yani.
            // 9-> Arraylar, biz oluşturduğumuz sınırlar içerisinde çalışır. 
            // 10-> Dışına çıkmaz.
            // 11-> Aklımıza şöyle bir şey gelebilir.
            //          isimler=new string[5];
            //          isimler[4] = "İlker";
            //          Console.WriteLine(isimler[4]);

            // 12-> Bunu yazar. Okey.
            // 13-> Buradan sonra   Console.WriteLine(isimler[0]); yazdığımda. yani şöyle
            //          isimler=new string[5];      // İSimler'in adresi yeni bir adres
            //          isimler[4] = "İlker";
            //          Console.WriteLine(isimler[4]);
            //          Console.WriteLine(isimler[0]);

            // 14-> ekrana 0. eleman gelmeyecek. Aslında geldi ama boş geldi.
            // 15-> Biz new dediğimiz anda, bellekte yeni bir şey oluşturur.
            // 16-> isimler adında yeni bir yer açtı bellekte. 5 elemanlı biz dizi oluşturmak istediğimiz de de
            // 17-> Yeni dizi oluşturduğu için tüm elemanlar boş. Ve ben gittim bu boş olan dizinin 5. elemanına İlker yazdırdım.
            // 18-> Ardından da gittim 0. elemanı çağırdım. Boş gelir tabii ki. Çünkü yeni bir dizi ve elemanlar boş.
            // 19-> Ama bu hareketi yani new'leme hareketini yaptığımda ilk başta vermiş olduğum engin, murat... olan diziyi kaybedeceğiz.
            // 20-> Daha dikkatli olmamız gerekiyor. Biraz daha farklı kullanım gerçekleştiriyoruz.

            // 21-> Biz gidip, burada Halil'in yanına İlker yazabiliriz ama bu gerçek hayatta; buradaki dizi bir veri kaynağından geliyor.
            // 22-> O data geldi, o dizi oluştu yani. Buna yeni bir şey eklettiğimde patlıyoruz. 4 elemanlı bir dizi oluşturudğumda yeni eleman
            // ekleyemiyorum. Ekleyebilsemde, diğer elemanları kaybediyorum
            // !!! new demek yeni referans adresi demek. !!!

            // 23-> Gerçek hayatta da dizileri genel anlamda kullanmayız. Java da da böyle. Bunun yerine KOLEKSİYONları kullanırız.

            List<string> isimler2 = new List<string> {"Engin", "Murat", "Kerem", "Halil"};

            // 24-> Yukarıdaki kodun aynısını yazdık.

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            // KOLEKSİYON'lar, dizilerden farklı olarak, elemanları rahatlıkla ekleyebiliyoruz. ve ekleme işlemini yaparken öncek elemanları kaybetmiyoruz
            // isimler2. yaptığımızda da bir sürü methodunun olduğunu görüyoruz.










        }
    }
}
