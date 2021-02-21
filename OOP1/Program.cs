using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // 1-> 2 numaranın arka planda mobilyaya karşılık geldiği varsayalım
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            // 2-> Yukarıdaki gibi yazılabildiği gibi, Bu şekilde de yazılabilir. Genel olarak bu şekilde yazılır.
            // 3-> Bunlar gerçek hayatta bir yerden alınır. Biz normal şartlarda bu şekilde yazmayız.

            // 4-> PascalCase  //camelCase
            ProductManager productManager = new ProductManager();

            // 5-> ProductManager türünde productManager anlamına geliyor. 
            // 6-> İsimlendirme kuralları önemli!!!!!
            // 7-> Case sensitive, c# büyük küçük harf duyarlıdır.

            // 8-> ProductManager türündeki productManager yeni bri referans numarası almış ProductManager'dir.

            productManager.Add(product1); // 9-> Ekranda, ürün bilgilerini girdiğimi varsayalım ve ürün ekleme butonuna bastım.
                                          // 10-> Sadece, productManager.Add() demekle olmaz.
                                          // 11-> Ekleyeceğim ama ne ekleyeceğim. 
                                          // 12-> Ne ekleyeceğim, aslında parametre ile göndereceğim şeydir.
                                          // 16-> product1 yazdığımda, ekleme işlemini gerçekleştirecek. 
                                          // 17-> product türünde nesneyi gönderdim. ProductManager'de product isminde tutuyor olacak.

            Console.WriteLine(product1.ProductName);


            //***************************************************************************
            //***                                                                     ***        
            //***    18-> int, double, bool.... Değer Tip                             ***
            //***    19-> Diziler, Cass, abstact class, interface... Referans Tip     ***
            //***                                                                     ***
            //***************************************************************************

            // 20-> Buraya gelsem desem ki
            //      int sayi=100;
            //      productManager.BiseyYap(sayi);
            //      Console.WriteLine(sayi);
            // 21-> Bu şekilde yazdığımda, BiseyYap fonksiyonunun içerisinde ben sayi'ye eşit olan değeri yolluyorum
            // 22-> Yani, sayi=100 olduğundan, 100 değerini yolluyorum. Bu kadar. 
            // 23-> BiseyYap fonksiyonuna gittiğinde orada da BiseyYap(int sayi) parametresi olduğundan, burası yeni bir "sayi" olmuş oluyor.
            // 24-> buradaki sayi'den bağımsız. ve bu sayiyi bu fonksiyon içerisinde değiştirdiğimizde burayı etkilemiyor.
            // 25-> Dolayısıyla; ekrana sayi değerini yazdırmak istediğimde 100 olarak karşıma çıkmış oluyor

            // 26-> Ama ama, ProductManager productManager = new ProductManager();
            // 27->          productManager.Add(product1);
            // 28->          Console.WriteLine(product1.ProductName);
            // 29-> Gibi bir program yazdığımızda; Burası Referans Tip olmuş oluyor. Aslında Biz:
            // 30-> ProductManager productManager = new ProductManager(); bu satırda 101 gibi fiziksel bir odayı belirtiyoruz.
            // 31-> Bundan dolayı .Add işlemini yaptırdığımda o odaya gidiyor oradaki işlemi yapıyor, geliyor ve burada devam ediyor.
            // 32-> O odadaki işlemi değiştirdiği/ yaptığı için, burada ekrana yazdırma işlemimizde; (Mesela buradaki Masa'yı, fonks. içinde Kamera yaptık) 
            // 33-> Odadaki değeri yazdırdığımız için, Masa değerini Kamera olarak değştirdiğimzden, Kamera İfadesini ekranda göreceğiz. 







        }
    }
}
