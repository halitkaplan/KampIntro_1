using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        // 1- Ben MyList'imde T ile çalışacağım. burası, string olabilir, int olabilir, bool olabilir.
        // 2- Ama ben kendi belirtmiş olduğum T tipi ile yazacağım. T yerine farklı bir şey de yazılabilir.
        // 3- Ama genel olarak T kullanılmaktadır.

        // 14-
        // 14.1-  string[] items; // Class'ın içerisinde yazdık. MEthodun değil. Yani, class'ın tüm elemanları buna erişebilir.
        // 14.2-  Peki burada string demem doğru mu? Hayır. T tipinde belirtmem gerekiyor.

        // 15-
        T[] items;    // 15.1- T items array'ini, class'ı newlediğimde oluşturmam gerekiyor. !!!!!!!!!!!!!!!
                      // 15.2- Bu oluşturacağımız dizi, 0 elemanlı bile olsa, newlememiz gerekiyor.
                      // 16- Bunun için: aşağdaki gibi 'ctor' yazıp tab tab yapıyoruz. Buna Constructor deniyor.
        public MyList()
        {
            // 16.1- Ben Class'ı bir yer de newlediğim zaman bu otomatik çalışıyor. bundan dolayı void felan yok. Direk çalışacak çünkü.  Ve Constructor deniyor.
            
            items = new T[0]; // 16.2- newlediğimiz an da array'i oluşturduk ve sıfır elemanlı olarak verdik. Süper oldu.
        }


        public void Add(T item) // 4- Buradaki parametre içine, string item yazarsam benim Add'im string ile çalışmak zorunda
        {                       // 5- Ben buraya T yazayım ki, programcı o an hangi tip ile çalışıyorsa o tipe göre parametreyi alsın.
                                // 6- bir şeye bağımlı olmasın yani. ben T türünde bir şey veriyorsam, istediğim elemanın türüde T dir.
                                // 7- item yazmaya gerek yok, farklı bir şey de yazabilirim.

            // 17- Burada ekleme işlemini yaparken, dizimin eleman sayısını 1 artırmak gerekiyor.  

           /// items = new T[items.Length+1]; // items.Lenght dizimin eleman sayısını verir. ve ben bunu 1 artırmak istiyorum. bunun için +1
                                           // Fakat burada şöyle bir sıkıntı da mevcut. ben bir eleman ekledim ve bunu 1 artırdım, fakat new işlemini yaptııııım.
                                           // new'leme işlemini yapınca ne oluyordu, diğer elemanlar uçuyordu.!!!!!!
                                           // Aslında uçan ne, referans numaram uçuyor. Bundan dolayı o referansı birine tutturmam gerekiyor.

            T[] tempArray = items;         // tempArray, Geçici dizi. 
                                           // Geçici dizinin referansı, items'ın referansı oldu.
                                           // onu geçici olarak bi arkadşaıma verdim.
                                           // sonra elemanı 1 artırma işlemini yapıyoruz.
            items = new T[items.Length + 1];
            // Şimdi şunu demem gerekiyor, Sana emanet ettiğim elemnları bana geri versene

            for (int i = 0; i < tempArray.Length; i++) // tempArray'in elemanları tekrar T ye atayacağım.
            {
                items[i] = tempArray[i]; // sırasıyla items'ın üzerine geri alıyorum.

            }

            items[items.Length - 1] = item;  // items 6 elemanlı oldu ise, 6-1 5. elemanı bizim son elemanımız oluyor. 
                                             // 0 dan başladığı için 0. 1. 2. 3. 4. 5. burası toplam 6 yapar 6-1=5. eleman benim son elemanımdır.


        }               
    }
}
