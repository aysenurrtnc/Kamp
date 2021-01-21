using System;

namespace MyDictionary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyDictionaryDemo<int, string> myDictionary = new MyDictionaryDemo<int, string>();
            myDictionary.Add(35, "İzmir");
            myDictionary.Add(06, "Ankara");

            foreach (var city in myDictionary.Values)
            {
                Console.WriteLine(city);
            }
        }
    }

  
}
