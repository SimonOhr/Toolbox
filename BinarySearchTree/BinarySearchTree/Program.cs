using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    enum PrintOrder { InOrder, PreOrder, PostOrder}
    
    class Program
    {
        static Random rnd = new Random();
        static BinarySearchTree tree;
        static int rootValue = 15, maxValue = 50, nmrOfValues = 30; // tree values
        static void Main(string[] args)
        {
            CreateRoot(rootValue);
            FillTree(maxValue, nmrOfValues);
            PrintTree();
            Console.ReadLine();
        }
        /// <summary>
        /// creats initial node with root value
        /// </summary>
        /// <param name="rootValue"></param>
        static void CreateRoot(int rootValue)
        {
            tree = new BinarySearchTree(rootValue);
        }
        /// <summary>
        /// toy function, just filling the tree with random numbers
        /// </summary>
        /// <param name="maxValue"></param>
        /// <param name="nmrOfValues"></param>
        static void FillTree(int maxValue, int nmrOfValues)
        {
            for (int i = 0; i < nmrOfValues; i++)
            {
                tree.Insert(rnd.Next(1, (maxValue+1)));
            }
        }
        /// <summary>
        /// prints tree in all orders
        /// </summary>
        static void PrintTree()
        {
            tree.Print(PrintOrder.InOrder);
            tree.Print(PrintOrder.PreOrder);
            tree.Print(PrintOrder.PostOrder);
        }

    }
}
