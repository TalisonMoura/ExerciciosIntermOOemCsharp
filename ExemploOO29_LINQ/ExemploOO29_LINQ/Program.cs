namespace ExemploOO29_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the date source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Define the query expressin
            // IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10); CONSULTA QUE DEMANDA UM RESULTADO MAIS GENERICO. CONSULTA DE LISTA É MUITO ESPECIFICO.
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);  
            
            // Execute the query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}