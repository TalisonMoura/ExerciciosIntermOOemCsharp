namespace ExemploOO23_ExtensionMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 02, 03, 7, 00, 00);

            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}