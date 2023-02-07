using ExemploOO28_Func.Entities;
namespace ExemploOO28_Func
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

            // Func<Product, string> func = NameUpper;  DECLARANDO UM DELEGATE PARA PASSAR COMO REFERENCIA NA FUNÇÃO LIST.SELECT
            // Func<Product, string> func = P => P.Name.ToUpper();  DECLARANDO UMA EXPRESSÃO LAMBDA PARA USAR COMO REFERENCIA NA FUNÇÃO LIST.SELECT


            // List<string> result = list.Select(NameUpper).ToList();
            // List<string> result = list.Select(func).ToList();
            List<string> result = list.Select(P => P.Name.ToUpper()).ToList(); // DECLARAÇÃO DA EXPRESSÃO LAMBDA INLINE


            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}