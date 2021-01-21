using System;

namespace MyDictionary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyDictionaryDemo<int, string> cities = new MyDictionaryDemo<int, string>();
            cities.Add(47, "Mardin");
            cities.Add(35, "İzmir");
            cities.Add(06, "Ankara");
            cities.Add(34, "İstanbul");
            cities.Add(61, "Trabzon");



            foreach (var city in cities.Values)
            {
                Console.WriteLine(city);
            }

            foreach (var plates in cities.Key)
            {
                Console.WriteLine(plates);
            }

        }
    }

  
}
