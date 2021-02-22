using System;

namespace MyListWithDictionaryQuestion5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string > kisiler = new MyDictionary<string, string>();
            kisiler.Add("1234567890", "Halit");
            kisiler.Add("0000000002", "Mehmet");
            kisiler.Add("1354897652", "Berk");

            kisiler.Listele();

        }
    }
}
