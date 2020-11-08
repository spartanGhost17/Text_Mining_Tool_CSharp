using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CourseWork_16059158
{
    public class BinTree<T> where T : IComparable
    {
        protected Node<T> root;
        public BinTree()
        {
            root = null;
        }

        public BinTree(Node<T> node)
        {
            root = node;
        }
        public void inOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }
        public void PreOrder(ref string buffer)
        {
            PreOrder(root, ref buffer);
        }
        public void PostOrder(ref string buffer)
        {
            PostOrder(root, ref buffer);
        }
        public void Copy(BinTree<T> tree2)
        {
            Copy(ref root, tree2.root);
        }
        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }
        }

        private void PreOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Left, ref buffer);
                inOrder(tree.Right, ref buffer);
            }
        }
        private void PostOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                inOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }
        private void Copy(ref Node<T> tree, Node<T> tree2)
        {
            while (tree != null)
            {
                tree.Data = tree2.Data;
            }
        }

    }

}
