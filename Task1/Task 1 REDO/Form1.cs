using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_REDO
{
    public partial class Form1 : Form
    {
        Queue queue = new Queue();

        public Form1()
        {
            InitializeComponent();
        }

        private void updateNumOfCustomersLabel()
        {
            int customerCount = queue.NumOfItems;
            float totalOwed = queue.CalculateTotalAmountOwed();
            Customer mostOwed = queue.getMostOwedCustomer();

            noOfCustomersLabel.Text = "Number of customers: " + customerCount.ToString();
            totalOwedLabel.Text = "Total amount owed by customers: " + totalOwed.ToString();

            mostOwedCustomerLabel.Text = "Name: " + mostOwed.Name + "\n" + "Age: " + mostOwed.Age.ToString() + "\n" + "Address: " + mostOwed.Address + "\n" + "Amount owed: " + mostOwed.AmountOwed.ToString() + "\n";
        }

        private void enqueueBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int age = Convert.ToInt32(ageInput.Text);
            string address = addressInput.Text;
            float amountOwed = float.Parse(amountOwedInput.Text);

            Customer customer = new Customer(name, age, address, amountOwed);
            queue.Enqueue(customer);

            updateNumOfCustomersLabel();
        }

        private void dequeueBtn_Click(object sender, EventArgs e)
        {
            Customer removedCustomer = queue.Dequeue();

            removedCustomerLabel.Text = "Name: " + removedCustomer.Name + "\n" + "Age: " + removedCustomer.Age.ToString() + "\n" + "Address: " + removedCustomer.Address + "\n" + "Amount owed: " + removedCustomer.AmountOwed.ToString() + "\n";

            updateNumOfCustomersLabel();
        }
    }
}
