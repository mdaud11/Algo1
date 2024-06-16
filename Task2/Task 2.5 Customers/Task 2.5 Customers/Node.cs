using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._5_Customers
{
    internal class Node
    {
        public Customer Data;
        public Node Left;
        public Node Right;


        public Node(Customer data)
        {
            Data = data;
        }

        public Node(Customer data, Node left, Node right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
    }
}
