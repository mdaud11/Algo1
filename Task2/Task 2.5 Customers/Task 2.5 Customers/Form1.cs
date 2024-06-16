using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2._5_Customers
{
    public partial class Form1 : Form
    {
        BinaryTree tree = new BinaryTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void modifyLabels()
        {
            totalCustomersLabel.Text = "Number of customers: " + tree.Count();
        }

        private string listToText(List<Customer> list)
        {
            string result = "";
            foreach (Customer c in list)
            {
                result += ("name: " + c.Name + "\n" + "age: " + c.Age.ToString() + "\n" + "address: " + c.Address + "\n" + "amount owed: " + c.AmountOwed + "\n" + "\n");
            }
            return result;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int age = Convert.ToInt32(ageInput.Text);
            string address = addressInput.Text;
            float amountOwed = float.Parse(amountInput.Text);

            tree.InsertItem(new Customer(name, age, address, amountOwed));
            modifyLabels();
        }

        private void preOrderbtn_Click(object sender, EventArgs e)
        {
            List<Customer> result = tree.PreOrder();
            sortedResultLabel.Text = listToText(result);
        }

        private void inOrderbtn_Click(object sender, EventArgs e)
        {
            List<Customer> result = tree.InOrder();
            sortedResultLabel.Text = listToText(result);
        }

        private void postOrderBtn_Click(object sender, EventArgs e)
        {
            List<Customer> result = tree.PostOrder();
            sortedResultLabel.Text = listToText(result);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name = searchInput.Text;
            Customer c = tree.SearchCustomer(name);
            if (c != null)
            {
                searchResultLabel.Text = "name: " + c.Name + "\n" + "age: " + c.Age.ToString() + "\n" + "address: " + c.Address + "\n" + "amount owed: " + c.AmountOwed;
            }
            else
            {
                searchResultLabel.Text = "Nothing found";
            }
        }
    }
}
