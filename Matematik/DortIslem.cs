using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) // Bu işlemi yapabilmemiz için, Topla işlemine 2 tane sayı vermemiz gerektiğini parametre şeklinde belirttik.
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);


        }
    }
}
