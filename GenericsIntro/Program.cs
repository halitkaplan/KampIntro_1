using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {            
            MyList<string> isimler = new MyList<string>(); // 8- Çalışacağım tipi burada söylüyorum.
                                                           // 9- string yazdığım için string tüürnde bir liste.
                                                           // 10- Product deseydim Product tipinde bir liste olurdu.
            isimler.Add("Engin");
            // 11- Ben bunu böyle yazdım ama Add methodunun içerisinde şu anlık bir şey yok. 

            // 12- Normal şartlarda kullanmış olduğumuz List, aslında arka planda bir array'i yönetmekte.
            // 13- Ben de bir array'i yönettiğimi varsayayım:

                                    

        }
    }
}
