using System;

namespace Constructors // 1- Constructor , Bir Class'ı newlediğimiz zaman çalışan bloıktur.
{                      // 2- 1 kere çalışır ve bir daha çalışmaz.

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Engin", LastName="Demiroğ", City="Ankara" }; // 7- bu bir yöntem.
            Customer customer2 = new Customer(2, "Derin","Demiroğ","Ankara"); //8- Bu da 2. yöntem
            // 9- Eğer ki ben 2. yöntemi kullanarak yapacaksam;
            // 10- public Customer()' ın içerisinde bu parametreleri de girmem gerekiyor
            // public Customer(int id, string firstName, string lastName, string city)

            // 11- Bunu yazdığımda ise, 1. uyguladığım yöntem kızacaktı. 
            // 12- Constructor yazdığım zaman, default constructor'u ezmiş olurum.
            // 13- Peki bu 2 yöntemi aynı anda kullanamaz mıyım?
            // 14- Yeni bir ctor oluştururum.

            // 16- COnstructorler de de overloading yapabiliyordum. Parametreli olanda biri, parametresiz olanda diğeri çalışacak.

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Halit";
            customer3.LastName = "Kaplan";
            customer3.City = "İstanbul";

            // customer1'i yazdığım gibi bu şekilde de yaabilirim.

            Console.WriteLine(customer2.FirstName);

        }
    }

   

    class Customer
    {

        //15-
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city) // 3- constructor oluşturmak için, ctor+tab+tab
        {                 // 4- 10. satırdaki kodu yazdığımızda ve satırın sonunda parantezi koyduğumuzda,
                          // 5- Default olarak burayı çalıştırırız. Yaz veya yazma, çalışır. Default Constructor deniyor.
                          // 6- Biz bir şey yazarsak, bizim yaptığımızı çalıştırır. Yazmadıysak Default Constructorü çalıştırır.

            // PArametreli olanda burası çalıştığı için şunları demeliyiz.
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            
            // Method Parametreleri Camel Case yazılır.


        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
