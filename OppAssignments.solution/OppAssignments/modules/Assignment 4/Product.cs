using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules.Assignment_4
{
    internal class Product
    {
        public Product()
        {
            this.name = "Unknown Product";
            this.price = 0.0m;
            this.quantity = 0;
        }
        public Product(string name, decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }

        public decimal CalculateTotal()
        {
            return this.price * this.quantity;
        }

        // calculate total
        public decimal CalculateTotal(decimal price, int quantity)
        {
            return price * quantity;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {name}");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total: {CalculateTotal():C}");
        }

    }
}