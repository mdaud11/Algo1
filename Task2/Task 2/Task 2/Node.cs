using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    internal class Node
    {

        public int Data;
        public Node Left;
        public Node Right;


        public Node(int data)
        { 
        Data = data;
        }

        public Node(int data, Node left, Node right)
        { 
            Data = data;
            Left = left;
            Right = right;
        }
    }
}
