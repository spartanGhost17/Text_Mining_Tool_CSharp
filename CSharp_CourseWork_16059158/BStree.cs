using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CourseWork_16059158
{
    public class BStree<T> : BinTree<T> where T : IComparable
    {
        public BStree()
        {
            root = null;
        }

        public Node<T> ROOT
        {
            get { return this.root; }
        }
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }
        public Node<T> FindNode(T item)
        {
            return FindNode(item, root);
            // return return_node;
        }
        public int Count()
        {
            return Count(root);
        }
        public Boolean Contains(T item)
        {
            return Contains(item, root);
        }
        public Node<T> removeItem(T item)
        {
            return removeItem(item, ref root);
        }
        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
                //tree.PARENT = tree;
            }

            else if (item.CompareTo(tree.Data) < 0)
            {

                insertItem(item, ref tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }

        }
        public int Height()
        {
            return Height(root);
        }

        protected int Height(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int one = Height(node.Left);
                int two = Height(node.Right);
                return 1 + Math.Max(one, two);
            }

        }
        private int Count(Node<T> node)
        {
            int a = 0;
            int b = 0;
            if (node.Left != null)
            {
                a = Count(node.Left);
            }

            if (node.Right != null)
            {
                b = Count(node.Right);
            }


            return (1 + a + b);
        }

        private Node<T> FindNode(T item, Node<T> node)
        {
            Node<T> result = null;
            if (node != null)
            {
                if (item.CompareTo(node.Data) == 0)
                {
                    result = node;
                }
                else
                {

                    if (item.CompareTo(node.Data) < 0)
                    {
                        FindNode(item, node.Left);
                    }
                    if (item.CompareTo(node.Data) > 0)
                    {
                        FindNode(item, node.Right);
                    }

                }
            }

            return result;
        }

        private Boolean Contains(T item, Node<T> node)
        {
            //Boolean result = false;
            if (node == null)
            { return false; }
            else if (item.CompareTo(node.Data) == 0)
            {
                return true;
            }
            else
            {

                if (item.CompareTo(node.Data) < 0)
                {
                    return Contains(item, node.Left);
                }
                if (item.CompareTo(node.Data) > 0)
                {
                    return Contains(item, node.Right);
                }

                else
                    return false;


            }

        }

        private Node<T> removeItem(T item, ref Node<T> node)
        {
            Node<T> myNode = null;
            if (Contains(item, node) == true)
            {
                if (item.CompareTo(node.Data) == 0)
                {
                    if (node.Left == null && node.Right == null)
                    {
                        node = null;
                        myNode = node;
                        //System.Console.WriteLine("balance1  " + myNode);
                    }

                    else if (node.Left != null && node.Right == null)
                    {
                        node = node.Left;
                        myNode = node;
                        //System.Console.WriteLine("balance2  " + myNode.BalanceFactor);
                    }

                    else if (node.Left == null && node.Right != null)
                    {
                        node = node.Right;
                        myNode = node;
                        //System.Console.WriteLine("balance3  " + myNode.BalanceFactor);
                    }

                    else
                    {
                        //if item is root go right then pass node
                        //else 
                        T tempData = smallest(node.Right);//check here in case item is on the 
                        removeItem(tempData);
                        node.Data = tempData;
                        myNode = node;
                        //System.Console.WriteLine("balance4  " + myNode.BalanceFactor);

                        // removeItem(smallest(node).Data, smallest(node).Left);

                    }
                }
                else
                {
                    if (item.CompareTo(node.Data) < 0)
                    {
                        removeItem(item, ref node.Left);
                    }

                    if (item.CompareTo(node.Data) > 0)
                    {
                        removeItem(item, ref node.Right);
                    }
                }

            }
            else
                System.Console.WriteLine("the item does not exist");
            return myNode;
        }

        protected T smallest(Node<T> node)
        {
            if (node.Left == null)
                return node.Data;
            else
                return smallest(node.Left);
        }
    }

}
