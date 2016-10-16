using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    public class BinarySearchTree<T>
    {
            public Node<T> Root { get; set; }

            public BinarySearchTree()
            {
                this.Root = null;
            }

            public void Insert(T value)
            {
                this.Root = Insert(value, this.Root);
            }

            public void Remove(T value)
            {
                this.Root = Remove(value, this.Root);
            }

            public void RemoveMin()
            {
                this.Root = RemoveMin(this.Root);
            }

            public void MakeEmpty()
            {
                this.Root = null;
            }

            public bool IsEmpty()
            {
                return this.Root == null;
            }
            private Node<T> FindMin(Node<T> value)
            {
                if (value != null)
                {
                    while (value.Left != null)
                    {
                        value = value.Left;
                    }
                }

                return value;
            }
            protected Node<T> Insert(T value, Node<T> element)
            {
                if (element == null)
                {
                    element = new Node<T>(value);
                }
                else if ((value as IComparable).CompareTo(element.Element) <= 0)
                {
                    element.Left = Insert(value, element.Left);
                }
                else if ((value as IComparable).CompareTo(element.Element) > 0)
                {
                    element.Right = Insert(value, element.Right);
                }              

                return element;
            }
            protected Node<T> RemoveMin(Node<T> value)
            {
                if (value == null)
                {
                    throw new Exception($"\n{value} not found");
                }
                else if (value.Left != null)
                {
                    value.Left = RemoveMin(value.Left);
                    return value;
                }
                else
                {
                    return value.Right;
                }
            }

            protected Node<T> Remove(T value, Node<T> element)
            {
                try{
                    if (element == null)
                    {
                        throw new Exception($"\n{value} not found");
                    }
                    else if ((value as IComparable).CompareTo(element.Element) < 0)
                    {
                        element.Left = Remove(value, element.Left);
                    }
                    else if ((value as IComparable).CompareTo(element.Element) > 0)
                    {
                        element.Right = Remove(value, element.Right);
                    }
                    else if (element.Left != null && element.Right != null)
                    {
                        element.Element = FindMin(element.Right).Element;
                        element.Right = RemoveMin(element.Right);
                    }
                    else
                    {
                        element = (element.Left != null) ? element.Left : element.Right;
                    }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }                

                return element;
            }
            public void Display()
            {
                Console.Write("Elements in the tree: ");

                if (!IsEmpty()) { Root.Display(Root); }                    
            }         
    }
}
