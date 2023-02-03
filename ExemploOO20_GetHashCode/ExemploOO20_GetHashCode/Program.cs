using ExemploOO20_GetHashCode.Entities;
namespace ExemploOO20_GetHashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client() { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b)); // COMPARAÇÃO EM RELACÃO AO CONTEÚDO.
            Console.WriteLine(a == b); // COMPARAÇÃO NA REFERÊNCIA DE MEMORIA.
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            
        }
    }
}