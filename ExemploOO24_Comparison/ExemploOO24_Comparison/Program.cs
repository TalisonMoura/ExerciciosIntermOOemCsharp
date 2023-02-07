using ExemploOO24_Comparison.Entities;
namespace ExemploOO24_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            
            // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());  EXPRESSAO LAMBDA ATRIBUÍDA A UMA VARIÁVEL TIPO DELEGATE 

            // list.Sort(CompareProducts);  REFERENCIA DE MÉTODO ATRIBUÍNDO A UMA VARIÁVEL TIPO DELEGATE.
            // list.Sort(comp);
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // EXPRESSÃO LAMBDA INLINE

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        /*    
        static int CompareProducts(Product p1, Product p2)  REFERENCIA SIMPLES DE MÉTODO COM PARAMETRO.
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        */
    }
}