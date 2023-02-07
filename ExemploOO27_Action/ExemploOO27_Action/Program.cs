using ExemploOO27_Action.Entities;

namespace ExemploOO27_Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 500.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = UpdatePrice;

            list.ForEach(UpdatePrice);
            list.ForEach(act);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        static void UpdatePrice(Product p) 
        {
            p.Price += p.Price * 0.1;
        }
    }
}