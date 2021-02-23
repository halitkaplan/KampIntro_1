using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // buradaki IhtiyacKrediManager , TasitKrediManager ya da KonutKrediManager yerine
            // IKrediManager desekte aynı sonucu elde edecektik
            // interfacelerde, o interfaceyi implemente eden classın referansını tutabiliyor.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           // ıhtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
           // tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            // Bunlar ekrandaki açılır kutular.

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService()); // newleme işlemini bu şekilde de yapabilirim
             basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
           //  basvuruManager.BasvuruYap(konutKrediManager, newlist<ILoggerService> {new DatabaseLogerService(), new smsLoggerService()}); Tek Loggerİloe çalışmadığım durumlarda List kullanırım.
            // Burası bizden IKrediManager krediManager istiyor ama, zaten IKRediManager hepsinin referansını tuttuğundan dolayı, burada ekranda ne seçildiyse

            // yani ekran başındaki görevli, müşterinin isteiğine göre hangi kredi türünü istediyse ve ne seçildiytse buraya o gönderilir.
            // Taşı kredisi seçildiyse taşıt kredisi gönderilir. İhtiyç ise ihtiyaç gödnerilir.
            // buraya zaten krediManager'i yollayamayız.


            // IKrediManager'de bir veri tipidir. string, int gibi düşünebiliriz.
            //List<IKrediManager> krediler = new List<IKrediManager>() { };
            // Bomboş bir liste oluşturduk.
            // Personel, İhtiyaç kredini seçti ve listeye ekledi diyelim.

            //List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager};

            // sonra dedim ki, ihtiyaç ve taşıt kredisi seçilsin.
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
