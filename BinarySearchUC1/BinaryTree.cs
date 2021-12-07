using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchUC1
{
    public class BinaryTree
    {
        public Node root = null;

        public void Insert(int i)
        {
            Node node = new Node();
            node.Data = i;
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.LeftNode;
                        if (current == null)
                        {
                            parent.LeftNode = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = node;
                            break;
                        }

                    }
                }
            }
        }

        // Console.WriteLine(node.Data + "Data added");


        public void TraverseInorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            TraverseInorder(root.LeftNode);
            Console.WriteLine(root.Data + " ");
            TraverseInorder(root.RightNode);

        }
        public void TraversePreorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.Data + " ");
            TraversePreorder(root.LeftNode);
            TraversePreorder(root.RightNode);
        }
        public void TrversePostorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            TrversePostorder(root.LeftNode);
            TrversePostorder(root.RightNode);
            Console.WriteLine(root.Data + " ");

        }


    }

}



