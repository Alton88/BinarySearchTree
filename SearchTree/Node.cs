using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    public class Node <T>
    {
        public T Element { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T element)
        {
            this.Element = element;
        }
        public void Display(Node<T> element)
        {
            if (element == null) { return; }
            
            Display(element.Left);

            Console.Write($"{element.Element} ");

            Display(element.Right);
        }
    }
}
