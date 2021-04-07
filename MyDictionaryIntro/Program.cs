using System;

namespace MyDictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Gokhan");

            Console.WriteLine(" true or false:"+ myDictionary.ContainsValue("Gokhan"));
            Console.WriteLine(" true or false:" + myDictionary.ContainsValue("GokhaN"));
            Console.WriteLine(" true or false:" + myDictionary.ContainsKey(1));
            Console.WriteLine(" true or false:" + myDictionary.ContainsKey(2));

            myDictionary.Add(1, "Gokhan");

            myDictionary.Clear();

            Console.WriteLine(" true or false:" + myDictionary.ContainsValue("Gokhan"));
            Console.WriteLine(" true or false:" + myDictionary.ContainsValue("GokhaN"));
            Console.WriteLine(" true or false:" + myDictionary.ContainsKey(1));
            Console.WriteLine(" true or false:" + myDictionary.ContainsKey(2));

            myDictionary.Add(1, "Gokhan");

            Console.WriteLine(" true or false:" + myDictionary.ContainsValue("Gokhan"));
            Console.WriteLine(" true or false:" + myDictionary.ContainsValue("GokhaN"));
            Console.WriteLine(" true or false:" + myDictionary.ContainsKey(1));
            Console.WriteLine(" true or false:" + myDictionary.ContainsKey(2));

        }
    }
}
