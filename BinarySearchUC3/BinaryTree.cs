using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchUC3
{
    class BinaryTree
    {
        public Node root = null;

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.data = i;
            if (root == null)
            {
                root = newNode;//if root is null assign newNode to root
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
                        current = current.LeftNode;
                        if (current == null)
                        {
                            parent.LeftNode = newNode;  //go left
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = newNode;  //go right
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
            Console.Write(root.data + " ");
            TraverseInorder(root.RightNode);

        }
        public void TraversePreorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.data + " ");
            TraversePreorder(root.LeftNode);

            TraversePreorder(root.RightNode);

        }
        public void TraversePostorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            TraversePostorder(root.LeftNode);

            TraversePostorder(root.RightNode);
            Console.Write(root.data + " ");
        }
        public bool SearchBST(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data == value)
            {
                return true;
            }
            else if (root.data > value)
            {
                return SearchBST(root.LeftNode, value);
            }
            else
            {
                return SearchBST(root.RightNode, value);
            }


        }

    }
}
