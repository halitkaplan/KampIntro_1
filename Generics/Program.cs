using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Lüleburgaz");
            sehirler.Add("Hatay");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();

            sehirler2.Add("İstanbul");
            sehirler2.Add("Eskişehir");
            sehirler2.Add("Sivas");
            sehirler2.Add("Erzurum");
            sehirler2.Add("Antalya");
            sehirler2.Add("Isparta");
            Console.WriteLine(sehirler2.Count);
        }
    }


    class MyList<T> // Generic class
    {
        T[] _array;

        // 35- 
        T[] _tempArray; // 35.1 - Geçici Array'imi oluşturuyorum. 
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            // 36-
            _tempArray = _array;  // 36.1- emanet ediyorum. Datayı tutuyor temp Array, referans numarasını aktarmış oluyorum aslında


            _array = new T[_array.Length+1];
            // 27- Ben, Dizinin eleman sayısını artırmak istediğimde diziyi newlemem gerektiğini biliyorum.
            // 28- Bundan dolayı, diziyi newlerken, Dizinin eleman sayısı +1 yapıyorum ki eleman sayısı +1 artsın.
            // 29- Şöyle bir şey de vardı: Ben Dizinin eleman sayısını +1 arttırdığımda dizimin önceki tüm dataların maalesef uçuyordu.
            // 30- Bunun için, önceki dataları ilk olarak elimde tutacağım, ardından dizinin eleman sayısını +1 artırdığımda tekrardan 
            // 31- o dataları bu yeni oluşan diziye alacağım
            // 32- İlk olarak, Emanet edeceğim geçici bir Array oluşturuyorum. ardından, eleman ekleme işlemini yapmadan önce, asıl Array'imdeki elemanları
            // 33- geçici olan array'e aktarıyorum. Asıl Arrayimdeki eleman sayısını +1 artırıyorum. Artırdıkta sonra, emanet etmiş olduğum, asıl dizimin önckei elemanlarını geri alıyorum
            // 34- En son, eleman ekleme işlemini gerçekleştiriyorum.

            // 37-  Eleman aktarma işlemini yapacağım.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // tempArray'e emanet ettiğim elemanları, Asıl Array'e aktarıyorum.
            }

            // 38- Son olarak, _array'in son elemanına da benim göndermiş olduğum elemanı eklemiş oluyorum
            // 39- _array'imin son elemanı nedir? _array'imin elemanları - 1 dir. Çünkü; meselai 0,1,2,3 elemanlı olsun. bu nedir, toplam 4 elemanlıdır.
            // 40- 0,1,2 yi ben öncesinde _tempArray'e emanet edip, ardındna geri almıştım. 3. boş. Bundan dolayı, _array.LEnght = 4 olduğu için -1 yaparak 3. elemana geliyorum ki bu da benim son elemanım olmuş oluyor.

            _array[_array.Length - 1] = item;
            //
        }

       // private int _count;

        public int Count
        {
            get { return _array.Length; }
           //  set { _count = value; }   // Count için Set edilmesini istemiyorum.
           // DİKKAT!!!! _array.Lenght 'i kadar saymasını istediğim için bu şekilde ayarladım. 
           // private int _count'u devre dışı bırakmam gerekiyor.

        }

    }
}


// NOTLAR : 

// 1- List'in olmadığını varsayalım. 
// 2- Kendimiz MyList oluşturalım.
// 3- Şöyle bir şey istiyorum, ben bu listeye ne gönderirsem, tipi o olsun.
// 4- Sürekli olarak tip değişimini yapmak istemiyorum. 
// 5- Öncesinde görmü olduğumuz 'List' bir classtır. 
// 6- Buradan yola çıkarak, bizim oluşturacağımız MyList'te bir classtır.
// 7- MyList<T> diyorum ki, Listemin hangi tipteolmasını istiyorsam, buraya o geliyor.
// 8- MyList<string> dersem, T : string oluyor. int dersem; T: int oluyor.
// 9- Bu liste için de özellikleri ekliyorum.
// 10- Mesela, Add demişim. T item demişim. Aynı şekilde, yukarıda ne gönderiyorsam;
// 11- buradaki item tipi de, yukarıda gönderdiğim oluyor. 
//--------------------------------------------------------------------------------------------------
// 12- List'ler aslında, arka planda array yönetiyor. 
// 13- o zaman biz de array yöneteceğiz.
// 14- İlk olarak 0 elemanlı bi dizi oluşturalım.
// 15- ben MyList'i newlediğim an, public MyList() çalışıyor.
// 16- MyList için, count özelliğini de eklemek istediğimi varsayıyorum.
// 17- bunun için, propfull+tab+tab yapıyorum.
// 18- 32 - 38 satırlar arasındaki kodlar karşıma gelecek.
// 19- 34. satırdakini Count olarak değiştiriyorum.
// 20- Count Özelliği için Set edeceğim bir şey yok. sadece almak istediğim için get özelliğini aktif
// 21- set özelliğini inaktif hale getiriyorum. Set özelliğini silebiliriz.
// 22- Bu noktada programı çalıştırdığımda hiç eleman eklemdiğimde 0 olarak ekrana yazacak.
// 23- cw kısmını eleman ekledikten sonra yazdığımda : 
// 24- list için 1 , MyList için 0 sayısını göreceğiz. 
// 25- Yani bizim MyList'imizin eleman ekleme olayı biraz sıkıntılı
// 26- 0 elemanlı bir dizi oluşturuk ama, eleman eklediğimde bu dizinin eleman sayısı +1 artmalı ki yer açılsın.
