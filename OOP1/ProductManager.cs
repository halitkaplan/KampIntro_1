using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) // 13-> Parametre olarak, bana bir tane ürün ver diyorum. Product türünde bir şey ver diyorum yani.
        {                                // 14-> Bi ürün gelmeli ki buraya, ekleyebilsin.
                                         // 15-> Program.cs ye bakıldığı zaman, Add için gönderilmesi gereken parametresnin Product türünde olmasını isteyecek zaten program.
                                         // 1-> Öncelikle bi mantık kuralım; Biz bir ürün ekleyeceksek, ekleme operasyonuna neyi ekleyeceğimizi söylememiz gerekir.

            // 18-> product isminde tutacak burada.

            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        // 34-> Buradaki void ne işe yarıyor????
        // 35-> void diye belirttiğimiz methodları şöyle düşünebiliriz.
        // 36-> Emir kiplerinde; Git Ekle, Git Sil, Git şunu yap, Git bunu yap şeklinde söylüyoruz
        // 37-> Bu işlem sonucunda, o işlem sonucunun ne olduğuna dair ekstra bir bilgiye ihtiyacımız yok diyelim.
        // 38-> O zaman void kullanıyorum
        // 39-> Ama

        // ****************************************************************************
        // **************************************************************************** 
        // ***     public int Topla(int sayi1, int sayi2)                           ***       
        // ***     {                                                                ***   
        // ***          return sayi1 + sayi2;                                       ***   
        // ***     }                                                                ***
        // ***                                                                      ***
        // ***                                                                      ***
        // ***                                                                      ***
        // ***      40-> Bu şekilde yaptığımda, içeride return etmiş oluyoruz.      ***
        // ***      41-> Şu şekilde de yapalım. bu int'i void yapalım.              ***
        // ***                                                                      ***
        // ***      public void Topla2(int sayi1, int sayi2)                        ***
        // ***      {                                                               ***
        // ***          Console.WriteLine(sayi1+sayi2);                             ***
        // ***      }                                                               ***
        // ***                                                                      ***
        // ****************************************************************************
        // ****************************************************************************

        // 42-> Peki burada da görüldüğü gibi, int'li yazsam ne olur, void li yazsam ne olur.

        // 43-> Buradaki Topla2 aslında işini yapıyor. sayi1 ve sayi2'yi topluyor, bunu ekrana yazdırıyor.

        // 44-> yazdığımız program bir işlem yapsın. 
        // 45-> ve bu yaptığı işlem sonucunun izerine bir şey katmasın. 
        // 46-> Yani; x satırında 3 ve 6 yı toplamak istiyorum ya da bir formül uyguluyorum.
        // 47-> ben bu formülün sonucunu, sonucunda çıkan değeri kullanmıyorsam, o zaman void yazarım.


        // 48-> Eğer ki; 3 ve 6 yı gönderdim, ve bunları gönderdiğimde yapılan işlem sonucunu 2 ile çarpmak istediğimde
        // 49-> Burada da anlaşıldığı gibi çıkan sonucu başka bir şey de kullanıyorum. 2 ile çarpıyorum.
        // 50-> uygulamış olduğum formül sonucunu başka bir formülde kullanıyorsam, İşte o zaman int kullanıyorum.
        // 51-> Bunun için return'u kullanıyorum.
        // 52-> return'da, bu işlem sonucunda ben sana int bir şey vereceğim diyor yani.


    }
}
