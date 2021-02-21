using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //Forein Key, kod okunulurluğunu artırmak için Ürünü belirten nesneyi ilk kısımlara yazarız
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }



    }
}

// Bu tip Class'larda sadece ve sadece Özellik bulunur. 
// Eklemek, silmek gibi işlemlerin bulunduğu sınıfa ise CRUD operasyonu diyoruz. 
// 
