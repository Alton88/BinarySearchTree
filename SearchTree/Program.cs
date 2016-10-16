using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> intTree = new BinarySearchTree<int>();
            intTree.Insert(1);
            intTree.Insert(3);
            intTree.Insert(2);
            intTree.Insert(4);
            intTree.Insert(6);
            intTree.Insert(5);

            intTree.Display();

            BinarySearchTree<char> charTree = new BinarySearchTree<char>();
            charTree.Insert('e');
            charTree.Insert('c');
            charTree.Insert('A');
            charTree.Insert('b');
            charTree.Insert('d');
            charTree.Insert('f');
            charTree.Insert('b');
            //charTree.Insert('a');

            charTree.Remove('a');
            charTree.Remove('b');
            
            charTree.Display();

            Console.ReadLine();
        }
    }
}
