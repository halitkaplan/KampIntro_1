using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Burada yaptığım şey Method injection
        // benim başvuru yapımda hangi loglayıcı olduğuna dair bir bilgi yok
        // sadece soyut halleri var. ben somut halleri enjekte ediyorum
        public void BasvuruYap(IKrediManager krediManager , ILoggerService loggerService) // Bu methodu aynı zamanda loglamak istiyorum dedim ve loglama yı yaptım.
        {    // Burada, birden fazla Loglama işlemi yapacaksam eğer, Sms atsın, mail atsın gibi, List<ILoggerService> logerServices diyorum
            // birden fazla yolladığım için de her bir Logger'i Foreach ile dönüyorum
             // 7- IKrediManager, Tüm kredi türlerinin referansını tutuyosa eğer buraya IKrediManager diyebilirim.
             // 8- Hangi kredi türünü istiyorsunuz diye sorulduğunda, Taşıt Kredisi seçildiği an burası taşıt kredisi olacak zaten.
             // 9- Ben buraya istediğim taşıt kredisini yollayabilirim.
             // 1- Başvuran bilgilerini değerlendirme
             //
             // 2- bu algoritma içerisinde bir de krediyi hesaplayalım.
             // 3- Ben buraya gelsem ve desem ki;

            //KonutKrediManager konutKrediManager = new KonutKrediManager(); //10- Bunun için bunu yazmamamlıyım.
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            loggerService.Log(); // 10- hangi loglama gönderildiyse ou logla diyorum

            // 4- Dediğim an, tüm hesaplama işlemi konut kredisi üzerinden hesaplanır.
            // 5- Bu bilgi bizim her şeyimiz'!!!!!!!!!!!!!!!!!!!!!!1
            // 6- Biz tüm başvuralı bu halde yazdığımız kod ile, tüm başvuruları konut kredisine bağımlı hale getirdik.



        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            // Birisi geldi, personele dedi ki, a kredisini alırsam ne kadar öderim, b kredisini alırsam ne kadar, c kredisini alırsam ne akdar öderim dedi
            // diğeri geldi, a ve b kredilerinin aralarında farklı kıyaslamak istedi,
            // başkası geldi, b ve c yi kıyaslamak istedi
            // başkası daha geldi, a,b ve c yi kıyaslamak istedi
            // Yani, karşılaştırma yapmak için, personelin sisteme göndereceği kredi sayısı farklıç
            // 1 tane de gönderebilir. 1000 tane kredi türü de gönderebilir.
            // IKrediManager aynı hepsinin referansını tutuyordu. Ama personlein göndereceği sayı belirsiz.
            // buradan yola çıkarak koleksiyon kullanmam gerektiğini anlıyorum.
            // personel 1 tane kredi türü de gönderebilir 1000 tane de gönderebilir.
            // bana bir liste ver ve bu listenin türü IKrediManager olsun diyorum.

            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); // listedeki her bir kredinin hesabını yapıyoruz.
            }

        }

    }
}
