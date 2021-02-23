using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // okunulurluğu artırmak için interfaceleri I ile başlatırız.
    { // tüm kredi çeşitleri, buradkai hesapla işlemini hepsi farklı ele almakta.
        // Bundan dolayı, buradaki hesapla, tek başına bir anlam ifade etmiyor.
        // Hesaplama işlemi; Konut kredisinde farklı, ihtiyaç kredisinde farklı, taşıt kredisinde farklı
        // Hesaplama işleminin içeriğii hepsi farklı şekilde yapmakta fakat hepsi hesaplama yapmakta.
        // Şöyle yorumlayabiliriz: İmzanın aynı olduğu ama içerisinin farklı olduğu durumlarda, Base de oluşturduğumuz Class'ı interfaceolarak oluştururuz.
        public void Hesapla(); 

        // bir interface şunu anlatır:
        // Eğer ki birisi; bu interfaceyi kullanırsa, o arkadaşım bu Hesapla Methodunu içermek zorunda
        // birden fazla methodta olabilir.
        // public void CiktiAlma() , public void BiseyYap() gibi

        // interface, Kurallardır ve bu kurallara hepsinin uyması gereklidir!!!
        // genellikle operasyonel programlarda kuallnılıyor.
        
       

        // interfaceleri, birbirlerinin alternatifi olan, kod içerikleri farklı olan yazılımlar için kullanırız.
        // Mesela buradaki tüm kredi çeşitlerinde geri ödeme planı vardır.
        // Tüm kredi çeşitlerinde hesaplama ortaktır. Fakat, hesaplama çeşidi farklıdır. Hesaplama işleri değişkenlik gösterir.
        // Örneğin, projemizde loglama yapmak istiyoruz. Kim ne zaman hangi operasyonu çağırdı mesela.
        // Loglama dediğimiz amani loglamayı farklı şekilde uygulayabiliriz.
        // Logları veritabanında tutabiliriz, dosyada tutabiliriz. sms ile loglama, mail atma, veritabanına yazma oglamanın alternatifi
        // Burada ortak olan şey hepsinin loglama işlemi aynı.
        // Ama, email atarken e mail loglama işlemleri yazılır. sms loglama işlemi ile mail loglama işlemleri farklıdır. 
        // SAdece 1 tane log işlemi istendi diyelim. Başka log işlemi yapmak istemiyor iç müşteri
        // Durum bu şekilde olsa bile, biz, İnterface kullanırız.
    }
}
