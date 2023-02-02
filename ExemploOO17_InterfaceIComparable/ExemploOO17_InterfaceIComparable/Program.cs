using ExemploOO17_InterfaceIComparable.Entities;

namespace ExemploOO17_InterfaceIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\temp\TesteI.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred {e.Message}");
            }
        }
    }
}