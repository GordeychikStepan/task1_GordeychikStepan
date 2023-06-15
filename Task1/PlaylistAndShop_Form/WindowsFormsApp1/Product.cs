using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Product
    {
        private decimal Price { get; set; }
        public string Name { get; set; }

        public Product (string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string GetInfo ()
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }
}
