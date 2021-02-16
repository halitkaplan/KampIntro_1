using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) //burada, bir method olduğunu anlayabiliriz. methodların Syntax'ı
        {                           // burada neyi eklemek istiyorum. Ürünü sepete eklemek istiyorum.
                                    // Bunun için, Parametremi vermem gerekiyor ki program neyi ekleyeceğini bilsin.

            Console.WriteLine("Sepete Eklendi : " + urun.Adi);

        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);

        }
    }

}
