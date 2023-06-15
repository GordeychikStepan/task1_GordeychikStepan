using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Shop
    {
        private Dictionary<Product, int> products;

        public Shop ()
        {
            products = new Dictionary<Product, int>();
        }

        public void AddProduct(Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                products[product] += count;
            } 
            else
            {
                products.Add(product, count);
            }
        }

        public void Sell(Product product)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 1)
                {
                    products.Remove(product);
                } else
                {
                    products[product]--;
                }
            } else
            {
                Console.WriteLine("Товар не найден!");
            }
        }

        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        public void WriteAllProducts(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var product in products)
            {
                listBox.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);
            }
        }
    }
}
