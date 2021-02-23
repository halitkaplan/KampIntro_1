using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }


    // Buradaki 7. satır ile 13. satırları seç
    // Alta kpayal ve hangi log işlemini yapacaksan adını değiştir.
    /*
     * 
     *    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }



    FileLoggerService olarak değiştirdim
    Filelogger'e bir kere sol tık ile imleci bırak
    ampüle bas
    move to ......cs 
    başka bir dosyaya aktar diyoruz
    yeni class olarak onu oluşturuyor

     * */
}
