using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemo0
{
    class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0];
        }


        public void Add(T item)
        {
            T[] tempArray = items;

            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i]= tempArray[i];
            }

            items[items.Length - 1] = item;
        }


        public void Listele()
        {
            Console.WriteLine("Ürün Eklendi :"+ " "+items[items.Length-1]);
            
        }

        public void ListAll()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void Update(T item)
        {
            
           // string Update_ürün = Convert.ToString(Console.ReadLine());


            for (int i = 0; i < items.Length; i++)
            {
                if (Convert.ToString(items[i])==Convert.ToString(item))
                {
                    Console.WriteLine("Ürün Mevcut.");
                    Console.WriteLine("Ürünü Güncellemek İster misiniz? Y or N");
                    string Yes = Convert.ToString(Console.ReadLine());
                    if (Yes=="Y")
                    {
                        Console.WriteLine("Yeni Ürünü Gir:");
                        string newItem = Convert.ToString(Console.ReadLine());
                       
                        items[i] = item;
                    }
                    else
                    {
                        Console.WriteLine("Güncelleme İptal Edildi.");
                    }

                }
             

            }
            

        }

     

        


        


    }

   
}
