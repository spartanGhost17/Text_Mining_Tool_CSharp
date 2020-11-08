using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CourseWork_16059158
{
    public class Node<T> where T : IComparable
    {
        private T data;
        public Node<T> Left, Right, parent;
        private int balanceFactor = 0;

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
            parent = null;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }
        }

        public Node<T> PARENT
        {
            set { parent = value; }
            get { return parent; }
        }
        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }

    }

}
