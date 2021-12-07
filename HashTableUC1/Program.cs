using System;

namespace HashTableUC1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);

            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "Or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");

            string hash3 = hash.Get("3");
            Console.WriteLine("The 3rd index is:" + hash3);
            string hash5 = hash.Get("5");
            Console.WriteLine("The 5th index is:" + hash5);



        }
       

        }
}
