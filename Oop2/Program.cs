using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "11111111111";
            //musteri1.MusteriNo = "12345";
            // musteri1.SirketAdi = "?";
            // burada şirket adı dedik ama, bu benimle ilgili değil
            // bu şirket ile alakalıdır.

            // Gerçek Müşteri - Tüzel Müşteri
            // 2 tane nesnem var, bunların ikisi de müşteri
            // bunlar sırf birbirine benziyor diye, birbirinin yerine kullanılamazlar!!!
            // bunların ikisi de müşteri fakat, FARKLI MÜŞTERİ TİPLERİDİR.
            // Birbirinin yerine kullanılamazlar!!!!!
            // musteri1MusteriTipi=1 ise gerçek, 2 ise tüzel gibi bir kod yazarsak;
            // Hatalı bir kod olur, çnlü, gerçek gibi görünüp arka planda tüzel müşteri gibi davranış sergileyebilir.
            // SOLID prensipleri

            // Bunlardan kacmak için ne yapacağız, gidip adam akıllı Class'ları mızı oluşturacağız.

            // Engin Demiroğ - Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            // kodlama.io - Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            // Dikakt edecek olursa, Musteri olarak oluşturduk
            // Yani, Musteri hem gerçek hem de tüzel musteriyi tutabiliyor.
            // Bir yerde new görürsek, bellekteki bir referans numarası olduğunu aklımıza getirmeliyiz.
            // Musteri, hem gerçek müşterinin hem de tüzel müşterinin referansını tutabiliyor.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            // ben hem musteri 1, 2, 3 ve 4 ü ekleyebildiğimi burada görüyoruz.

            // Bizim bir base sınıfımız vasa, o sınıf referans tutucudur. 
        }
    }
}
