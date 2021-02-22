using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryKamp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1- Dictionary Sınıfı için de bizim belirleyeceğimiz bir key'e uygun olarak 
            değer saklar

             2- Key türünü belirlememiz şart (string, int...)
             */

            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            // veri ekleme işlemini yapıyoruz.
            AdYas.Add("Ahmet",25);
            AdYas.Add("Mehmet", 17);
            AdYas.Add("Burak", 55);


            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }

            // Değer Sayma özelliği
            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("Eleman Sayısı : "+ eleman);

            // Silme işlemi de var

            AdYas.Remove("Burak");
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            Console.ReadLine();




        }
    }
}
