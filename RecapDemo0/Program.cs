using System;
using System.Collections.Generic;

namespace RecapDemo0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  kendi mylist'imizi oluştururak ürün ekleme, güncelleme ve silme işlemlerimizi yapalım.
             * 
             */

            // 1- ilk önce List gibi, mylist class oluşturalım
            // 2- mylist classı mızı tasarlayalım.
            MyList<string> ürünler = new MyList<string>();
            for (int i = 1; i < 2; i++)
            {
                string ürün = Convert.ToString(Console.ReadLine());
                //   string sorgu = Convert.ToString(Console.ReadLine());
                if (ürün != "Update Mode ON") 
                {
                    if (ürün!="ListAll")
                    {
                        ürünler.Add(ürün);
                        ürünler.Listele();
                    }
                   
                }

                if (ürün == "Update Mode ON")
                {
                    Console.WriteLine("Güncellenmek istenen ürün adı nedir?");
                    string Update_ürün = Convert.ToString(Console.ReadLine());
                    ürünler.Update(Update_ürün);
                }
                
                if (ürün=="ListAll")
                {
                    ürünler.ListAll();
                }
                
                i--;
            }

           


            

        }

    }
}
