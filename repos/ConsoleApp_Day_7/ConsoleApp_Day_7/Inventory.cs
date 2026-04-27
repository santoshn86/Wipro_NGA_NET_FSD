using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Day_7
{
    internal class Inventory
    {
        private List<Product> products = new List<Product>();

        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < products.Count)
                    return products[index];
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < products.Count)
                    products[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public int Count
        {
            get { return products.Count; }
        }

    }
}
