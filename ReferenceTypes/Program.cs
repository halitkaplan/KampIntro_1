using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean..... Değer tiplerdir.

          
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            Console.WriteLine("Sayi1:" + sayi1);


            // Arrayler, Class'lar, Interface'ler...... Referans Tiplerdir.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayilar1[0]= " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;  // referans tip old. için referans numaralarından gider. Dolayısıyla Person2 FirstName'i de Engin olur.
                                // Aslında burada Adres eşitlemesi yapıyoruz
            person1.FirstName = "Derin"; // böyle yazdığımda PErson2 nin de FirstName'si değişecek

            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";


            Employee employee = new Employee();
            employee.FirstName = "Veli";

            // customer = employee; // Bunu diyemiyoruz çünkü farklı tipler !!!!!

            Person person3 = customer; // Bunu yaptığımda hata vermez. Çünkü biz Customer class'ını, Customer'lerde bir Person'dır diye tanımlamıştık zaten
                                       // Bundan dolayı kızmadı.

            // Buraya şey yazsam; customer.FirstName="Ahmet"; yazsam, person3=customer olduğundan dolayı 
            // ve ekrana person3.FirstNames'ini yazdırdığımda Ahmet olduğunu göreceğim
            // person.     dediğim zaman Id, FirstName, LastName gibi seçenekleri göreceğim
            // Ama customer da olan CreditCardNumber'i göremeyeceğim. Person için özel olanları Customer için de kullanabiliyorum
            // Fakat, Customer için özel olanı, Person için kullanamıyorum. Buradan anladığım şey şu, bir sınıfın yani müşteri yönetici gibi,
            // ortak olan özeliklerini bir sınıfta belirtiyorum, ve diğerlerini de ortak olan sııf ile inherit ediyorum.
            


            Console.WriteLine(person3.FirstName);  // Salih olarak ekranda göreceğiz.
            Console.WriteLine(((Customer)person3).CreditCardNumber);  // Customer Boxing'i yaptım. person3. dediğim zaman, her şeyi göreceğiz. Id, FirstName, LastName,CreditCardNumber'i tüm özellikleri görebilirim.


            PersonManager personManager = new PersonManager();
            personManager.Add(employee); // Buraya ne gönderirsem göndereyim herhangi bir sıkıntı olmayacak. 
                                         // Add işleminde PErson yazmama rağmen, employee'yi gönderdim.



        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }

    }

    // base class : Person (Person base class olmuş oluyor)
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }


    class PersonManager
    {
        public void Add(Person person) // Buraya, Customer customer dersem sadece customer ile çalışırım
        {                                  // Employee employee dersem, yalnızda employee ile çalışırım.
                                           // Ancak, Person person dersem, Person,Customer, Employee ile çalışırım yani hepsiyle

            Console.WriteLine(person.FirstName);

                                            // AYNI KODU FARKLI NESNELER İÇİN ÇALIŞTIRABİLME İMKANI SUNUYOR.
        
        }
    }
}
