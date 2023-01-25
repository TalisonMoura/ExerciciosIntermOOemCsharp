namespace ExemploOO05_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed!");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Format Error! {e.Message}");
            }
        }
    }
}