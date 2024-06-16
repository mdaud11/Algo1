using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    internal class BinaryTree
    {
        private Node root;

        public BinaryTree() { }

        public BinaryTree(Node root)
        {
            this.root = root;
        }

        public void InsertItem(int item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(int item, ref Node tree)
        {
            if (tree == null) tree = new Node(item);
            else if (item < tree.Data) insertItem(item, ref tree.Left);
            else if (item > tree.Data) insertItem(item, ref tree.Right);
        }
        public int Count()
        {
            return count(root);
        }
        private int count(Node tree)
        {
            if (tree == null) return 0;
            return count(tree.Left) + count(tree.Right) + 1;
        }

        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            preOrder(root, ref result);
            return result;
        }

        public List<int> InOrder()
        {
            List<int> result = new List<int>();
            inOrder(root, ref result);
            return result;
        }

        public List<int> PostOrder()
        {
            List<int> result = new List<int>();
            postOrder(root, ref result);
            return result;
        }

        private void preOrder(Node tree, ref List<int> result)
        {
            if (tree != null)
            {
                result.Add(tree.Data);
                preOrder(tree.Left, ref result);
                preOrder(tree.Right, ref result);
            }
        }

        private void inOrder(Node tree, ref List<int> result)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref result);
                result.Add(tree.Data);
                inOrder(tree.Right, ref result);
            }
        }

        private void postOrder(Node tree, ref List<int> result)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref result);
                postOrder(tree.Right, ref result);
                result.Add(tree.Data);
            }
        }
    }
}
