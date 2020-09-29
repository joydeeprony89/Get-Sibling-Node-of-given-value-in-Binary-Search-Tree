using System;

namespace Get_Sibling_Node_of_given_value_in_Binary_Search_Tree
{
    class Program
    {
        public class Node
        {
            public int value { get; set; }
            public Node left, right;
            public Node(int value = 0)
            {
                this.value = value;
                left = right = null;
            }
        }
        static void Main(string[] args)
        {
            Node root = new Node(8);
            root.left = new Node(3);
            root.right = new Node(10);
            root.left.left = new Node(1);
            root.left.right = new Node(6);
            root.left.right.left = new Node(4);
            root.left.right.right = new Node(7);
            root.right.right = new Node(14);
            root.right.right.left = new Node(13);
            Console.WriteLine("Print Sibling of 13");
            Console.WriteLine(GetSibling(root, 13));
        }

        static int GetSibling(Node root, int key)
        {
            if (root == null) return 0;

            Node parent = null;
            while (root != null)
            {
                if (key < root.value)
                {
                    root = root.left;
                }
                else if(key > root.value)
                {
                    parent = root;
                    root = root.right;
                }
                else
                {
                    break;
                }
            }

            if (key == parent.left?.value) return parent.right.value;
            if (key == parent.right?.value) return parent.left.value;

            return 0;
        }
    }
}
