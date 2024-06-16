﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._5_Customers
{
    internal class Customer: IComparable<Customer>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public float AmountOwed { get; set; }

        public Customer(string name, int age, string address, float amountOwed)
        {
            Name = name;
            Age = age;
            Address = address;
            AmountOwed = amountOwed;
        }

        public string GetInformation()
        {
            return "Name is " + Name + " and age is " + Age + " and address is " + Address + " and amount owed is " + AmountOwed;
        }

        public int CompareTo(Customer other)
        {
            if (other == null) return 1;
            return Name.ToLower().CompareTo(other.Name.ToLower());
        }
    }
}
