using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{  
    class BinarySearchTree
    {           
        PrintOrder printOrder;
        Node rootNode;    
        public BinarySearchTree(int data)
        {            
            rootNode = new Node(data);
        }

        public void Insert(int data)
        {
            rootNode.Insert(data);
        }

        public bool DoesContain(int data)
        {
            return rootNode.Contains(data);
        }

        public void Print(PrintOrder printOrder)
        {
            this.printOrder = printOrder;
            switch (printOrder)
            {
                case PrintOrder.InOrder:
                    Console.WriteLine("InOrder");
                    rootNode.PrintInOrder();
                    break;
                case PrintOrder.PreOrder:
                    Console.WriteLine("\tPreOrder");
                    rootNode.PrintPreOrder();
                    break;
                case PrintOrder.PostOrder:
                    Console.WriteLine("\t\tPostOrder");
                    rootNode.PrintPostOrder();
                    break;
                default:
                    break;
            }
        }        
    }    
}
