using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioOO03_Order.Entities.Enum;

namespace ExercicioOO03_Order.Entities
{
    internal class Order
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public Client client { get; set; }
        
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }
        public void RemoveIntem(OrderItem item)
        {
            items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {client}");
            sb.AppendLine("Order items:");   
            foreach (OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: $ {Total().ToString("f2", ci)}");
            return sb.ToString();
        }
    }
}
