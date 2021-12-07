using System;

namespace BinarySearchUC2
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree obj1 = new BinaryTree();
            obj1.Insert(56);
            obj1.Insert(30);
            obj1.Insert(70);
            obj1.Insert(22);
            obj1.Insert(40);
            obj1.Insert(60);
            obj1.Insert(95);
            obj1.Insert(11); 
            obj1.Insert(65);
            obj1.Insert(3);
            obj1.Insert(16);
            obj1.Insert(63);
            obj1.Insert(67);
            obj1.TraverseInorder(obj1.root);
            Console.WriteLine();
            obj1.TraversePostorder(obj1.root);
            Console.WriteLine();
            obj1.TravesePreorder(obj1.root);
            Console.WriteLine();

        }
    }
}
