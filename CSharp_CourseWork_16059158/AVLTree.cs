using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CourseWork_16059158
{
    public class AVLTree<T> : BStree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }
        public void removeItemAVLT(T item)
        {
            removeItemAVLT(item, ref root);
        }

        public void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
                rotateRight(ref tree.Right);


            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Right;
            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;
            tree = newRoot;
        }

        public void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
                rotateLeft(ref tree.Left);

            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Left;

            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;

            tree = newRoot;

        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            updateBalance(ref tree);//update balance factor
                                    // System.Console.WriteLine("node " + tree.Data + " balance factor " + tree.BalanceFactor);
            rebalanceTree(ref tree);//rotate LL LR RL RR base on balance factor

        }

        private void updateBalance(ref Node<T> tree)
        {
            tree.BalanceFactor = Height(tree.Left) - Height(tree.Right);
        }

        private void rebalanceTree(ref Node<T> tree)
        {

            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);

        }

        private void removeItemAVLT(T item, ref Node<T> node)
        {
            //  System.Console.WriteLine(" delete method ------------------- \n");
            if (Contains(item))
            {
                Node<T> myNode;//= removeItem(item);
                if (item.CompareTo(node.Data) == 0)
                {
                    if (node.Left == null && node.Right == null)
                    {
                        node = null;
                        myNode = node;
                        // System.Console.WriteLine("balance1  " + myNode);
                    }

                    else if (node.Left != null && node.Right == null)
                    {
                        node = node.Left;
                        myNode = node;
                        // System.Console.WriteLine("balance2  " + myNode.BalanceFactor);
                    }

                    else if (node.Left == null && node.Right != null)
                    {
                        node = node.Right;
                        myNode = node;
                        // System.Console.WriteLine("balance3  " + myNode.BalanceFactor);
                    }

                    else
                    {
                        //if item is root go right then pass node
                        //else 
                        T tempData = smallest(node.Right);//check here in case item is on the 
                        removeItem(tempData);
                        node.Data = tempData;
                        myNode = node;
                        //  System.Console.WriteLine("balance4  " + myNode.BalanceFactor);

                        // removeItem(smallest(node).Data, smallest(node).Left);

                    }
                }
                else
                {
                    if (item.CompareTo(node.Data) < 0)
                    {
                        removeItemAVLT(item, ref node.Left);
                    }

                    if (item.CompareTo(node.Data) > 0)
                    {
                        removeItemAVLT(item, ref node.Right);
                    }
                }

                if (node != null)
                {
                    updateBalance(ref node);
                    // System.Console.WriteLine("node " + node.Data + "New balance factor " + node.BalanceFactor);
                    rebalanceTree(ref node);
                }

            }
        }
    }

}
