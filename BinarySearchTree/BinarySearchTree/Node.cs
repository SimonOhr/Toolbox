using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        int data;
        Node left, right;
        public Node(int data)
        {
            this.data = data;
        }

        public void Insert(int value)
        {
            if (value <= data)
            {
                if (left == null) left = new Node(value);
                else left.Insert(value);
            }
            else
            {
                if (right == null) right = new Node(value);
                else right.Insert(value);
            }
        }

        public bool Contains(int value)
        {
            if (value == data) return true;
            else if (value < data) if (left == null) return false;
                else return left.Contains(value);

            else
            {
                if (right == null) return false;
                else return right.Contains(value);
            }
        }

        public void PrintInOrder()
        {
            if (left != null)
                left.PrintInOrder();
            Console.WriteLine(data);
            if (right != null)
                right.PrintInOrder();
        }

        public void PrintPreOrder()
        {
            string spacing = "\t";
            Console.WriteLine(spacing + data);
            if (left != null) left.PrintPreOrder();
            if (right != null) right.PrintPreOrder();
        }

        public void PrintPostOrder()
        {
            string spacing = "\t\t";
            if (left != null) left.PrintPostOrder();
            if (right != null) right.PrintPostOrder();
            Console.WriteLine(spacing + data);
        }
    }
}
