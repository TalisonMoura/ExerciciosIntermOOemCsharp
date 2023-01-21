using ExercicioOO03_Order.Entities;
using ExercicioOO03_Order.Entities.Enum;
using System.Globalization;

namespace ExercicioOO03_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
             
            
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string ClientName = Console.ReadLine();
            Console.Write("Email: ");
            string ClientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime ClientBirthDate = DateTime.Parse(Console.ReadLine()); 
            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Client client = new Client(ClientName,ClientEmail,ClientBirthDate);
            Order order = new Order(DateTime.Now, status,client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string ProductName = Console.ReadLine();
                Console.Write("Product price: ");
                double ProductPrice = double.Parse(Console.ReadLine(), ci);
                
                Product product = new Product(ProductName, ProductPrice);
                
                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(ProductPrice,Quantity,product);
                
                order.AddItem(orderItem);
                Console.WriteLine();
            }
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}