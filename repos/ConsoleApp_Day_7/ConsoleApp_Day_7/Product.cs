using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Day_7
{
    internal class Product
    {
        private string name;
        private decimal price;
        private int quantity;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative");
                price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative");
                quantity = value;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
