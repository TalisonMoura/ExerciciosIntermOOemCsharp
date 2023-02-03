using ExemploOO19_RestricoesGenerics.Entities;
using ExemploOO19_RestricoesGenerics.Services;
using System.Globalization;

namespace ExemploOO19_RestricoesGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], ci);
                
                list.Add(new Product(name,price));
            }
        
            CalculationService cs = new CalculationService();
            
            Product max = cs.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}