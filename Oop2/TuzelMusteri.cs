using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate
    // inheritance diyoruz : Musteri olayına
    class TuzelMusteri : Musteri
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

        // Id ve MusteriNo gerçek ve Tüzel kişiler için ortak.
        // Vergi numarasının şimdilik tüzel müşteri için geçerli olduğunu düşünelim.

        /* Musteri'nin içerisinde olan her şey, Tuzel Musteri için de geçerlidir
         * Id ve Musteri No, hem gerçek hem tüzel müşteriler için ortak old. için gittim onu musteri Class'ına yzdım.
         * Burada Yalnızca, kendine has olan özelliklerini kullandım.
         */
    }
}
