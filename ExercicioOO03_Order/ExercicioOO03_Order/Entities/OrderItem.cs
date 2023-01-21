using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO03_Order.Entities
{
    internal class OrderItem
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product product { get; set; }

        public OrderItem() { }

        public OrderItem(double price, int quantity, Product product)
        {
            Price = price;
            Quantity = quantity;
            this.product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return ($"{product.Name}, R$ {Price.ToString("f2", ci)}, Quantity: {Quantity}, SubTotal: {SubTotal().ToString("f2", ci)}");
        }
    }
}
