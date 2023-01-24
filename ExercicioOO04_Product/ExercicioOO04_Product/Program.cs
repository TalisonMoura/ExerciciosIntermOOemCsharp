using ExercicioOO04_Product.Entities;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

namespace ExercicioOO04_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, Used or Imported (c/u/i)? ");
                char Type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Price: ");
                double Price = double.Parse(Console.ReadLine(), ci);
                if (Type == 'c' || Type == 'C')
                {
                    Product pd = new Product(Name, Price);
                    list.Add(pd);
                    Console.WriteLine();
                }
                else if (Type == 'u' || Type == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dta = DateTime.Parse(Console.ReadLine());
                    UsedProduct up = new UsedProduct(Name, Price, dta);
                    list.Add(up);
                    Console.WriteLine();
                }
                else if (Type == 'i' || Type == 'I')
                {
                    Console.Write("Customs Fee: ");
                    double Customs = double.Parse(Console.ReadLine(), ci);
                    ImportedProduct ip = new ImportedProduct(Name, Price, Customs);
                    list.Add(ip);
                    Console.WriteLine();
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
            
        }
    }
}