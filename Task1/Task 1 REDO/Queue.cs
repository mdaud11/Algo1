using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_REDO
{
    internal class Queue
    {
        private int maxSize = 10;

        private Customer[] store;

        private int head = 0;
        private int tail = 0;

        private int numOfItems = 0;
        public int NumOfItems
        {
            get
            {
                return numOfItems;
            }
        }
        public Queue()
        {
            store = new Customer[maxSize];
        }
        public void Enqueue(Customer value)
        {
            store[tail] = value;
            if (tail == (maxSize - 1)) tail = 0;
            else tail++;

            numOfItems++;
        }
        public Customer Dequeue()
        {
            Customer removedItem = store[head];
            if (head == (maxSize - 1)) head = 0;
            else head++;

            numOfItems--;

            return removedItem;
        }
        public Customer Peek()
        {
            return store[head];
        }
        public float CalculateTotalAmountOwed()
        {
            float totalAmountOwed = 0;
            for (int i = head; i < tail; i++)
            {
                totalAmountOwed += store[i].AmountOwed;
            }
            return totalAmountOwed;
        }
        public Customer getMostOwedCustomer()
        {
            Customer mostOwedCustomer = store[head];
            for (int i = head; i < tail; i++)
            {
                Customer currentCustomerInLoop = store[i];
                if (currentCustomerInLoop.AmountOwed > mostOwedCustomer.AmountOwed) mostOwedCustomer = currentCustomerInLoop;
            }
            return mostOwedCustomer;
        }
    }
}
