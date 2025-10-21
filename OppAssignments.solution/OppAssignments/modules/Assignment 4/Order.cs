using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
namespace OppAssignments.modules.Assignment_4
{
    internal class Order
    {
        public Order(int orderID, string CustomerName)
        {
            this.orderID = orderID;
            this.CustomerName = CustomerName;
            this.products = new List<Product>();
        
        }
        public int orderID { get; set; }
        public string CustomerName { get; set; }
        public List<Product> products { get; set; }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
            Console.WriteLine($"{product.name} added to order");
        }
        public decimal CalculateOrderTotal()
        {
            decimal total = 0;
            for (int i = 0; i < this.products.Count; i++)
            {
                total = total + products[i].CalculateTotal();
            }
            return total;
        }
        public void OrderSummary()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Order ID: {orderID}");
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Number of Products: {products.Count}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Products");
            for (int i = 0;i < this.products.Count;i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].name} - {products[i].quantity} x {products[i].price:C} = {products[i].CalculateTotal():C}");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine($"TOTAL ORDER COST: {CalculateOrderTotal():C}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        }
    }

