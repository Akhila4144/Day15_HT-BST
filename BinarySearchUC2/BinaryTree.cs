using System;
using System.Collections.Generic;
using System.Text;


namespace BinarySearchUC2
{
    public class BinaryTree
    {
        public Node root = null;

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        parent.LeftNode = newNode;
                        break;
                    }

                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = newNode;
                            break;
                        }
                    }

                }

            }
        }


            public void TraverseInorder(Node root)
            {
                if (root == null)
                {
                    return;
                }
                TraverseInorder(root.LeftNode);
                Console.Write(root.data + "");
                TraverseInorder(root.RightNode);
            }

            public void TravesePreorder(Node root)
            {
                if (root == null)
                {
                    return;
                }
                Console.WriteLine(root.data + "");
                TravesePreorder(root.LeftNode);
                TravesePreorder(root.RightNode);
            }
            public void TraversePostorder(Node root)
            {
                if (root == null)
                {
                    return;
                }
                TraversePostorder(root.LeftNode);
                TraversePostorder(root.RightNode);
                Console.WriteLine(root.data + "");
            }
        }
    }

             
           