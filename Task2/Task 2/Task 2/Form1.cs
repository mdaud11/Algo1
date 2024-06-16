using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        BinaryTree tree = new BinaryTree();

        public Form1()
        {
            InitializeComponent();
        }

        private string listToString(List<int> list)
        {
            string result = "";
            foreach (int i in list)
            {
                result += (i.ToString() + ", ");
            }
            return result;
        }

        private void modifyLabels()
        {
            numOfItems.Text = "Number of Items: " + tree.Count().ToString();
        }

        private void addnumber_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numberInput.Text);
            tree.InsertItem(id);
            modifyLabels();
        }

        private void preOrderBtn_Click(object sender, EventArgs e)
        {
            List<int> result = tree.PreOrder();
            sortingResultLabel.Text = listToString(result);
        }

        private void inOrderBtn_Click(object sender, EventArgs e)
        {
            List<int> result = tree.InOrder();
            sortingResultLabel.Text = listToString(result);
        }

        private void postOrderBtn_Click(object sender, EventArgs e)
        {
            List<int> result = tree.PostOrder();
            sortingResultLabel.Text = listToString(result);
        }

        /*
        int id = Convert.ToInt32(numberInput.Text);
        tree.InsertItem(id);
            modifyLabels();
        */

    }
}
