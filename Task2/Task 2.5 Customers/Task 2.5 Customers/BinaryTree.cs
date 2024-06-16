using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._5_Customers
{
    internal class BinaryTree
    {
        private Node root;

        public BinaryTree() { }

        public BinaryTree(Node root)
        {
            this.root = root;
        }

        public void InsertItem(Customer item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(Customer item, ref Node tree)
        {
            if (tree == null) tree = new Node(item);
            else if (item.CompareTo(tree.Data) < 0) insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0) insertItem(item, ref tree.Right);
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

        public List<Customer> PreOrder()
        {
            List<Customer> result = new List<Customer>();
            preOrder(root, ref result);
            return result;
        }

        public List<Customer> InOrder()
        {
            List<Customer> result = new List<Customer>();
            inOrder(root, ref result);
            return result;
        }

        public List<Customer> PostOrder()
        {
            List<Customer> result = new List<Customer>();
            postOrder(root, ref result);
            return result;
        }

        private void preOrder(Node tree, ref List<Customer> result)
        {
            if (tree != null)
            {
                result.Add(tree.Data);
                preOrder(tree.Left, ref result);
                preOrder(tree.Right, ref result);
            }
        }

        private void inOrder(Node tree, ref List<Customer> result)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref result);
                result.Add(tree.Data);
                inOrder(tree.Right, ref result);
            }
        }

        private void postOrder(Node tree, ref List<Customer> result)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref result);
                postOrder(tree.Right, ref result);
                result.Add(tree.Data);
            }
        }

        public Customer SearchCustomer(string name)
        {
            return searchCustomer(root, name);
        }

        private Customer searchCustomer(Node tree, string name)
        {
            if (tree == null) return null;
            if (name.ToLower().CompareTo(tree.Data.Name.ToLower()) == 0) return tree.Data;
            else if (name.ToLower().CompareTo(tree.Data.Name.ToLower()) < 0) return searchCustomer(tree.Left, name);
            else return searchCustomer(tree.Right, name);
        }
    }
}
