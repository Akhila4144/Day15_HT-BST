using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable numbernames = new Hashtable();
            numbernames.Add(1, "one");
            numbernames.Add(2, "two");
            numbernames.Add(3, "three");
            foreach(DictionaryEntry item in numbernames)
            {
                Console.WriteLine(item.Key + "" + item.Value);
            }
            Console.WriteLine(numbernames.ContainsKey(1));
        }
    }
}
