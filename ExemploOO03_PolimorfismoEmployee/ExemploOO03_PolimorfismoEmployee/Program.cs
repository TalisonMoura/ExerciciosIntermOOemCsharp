using ExemploOO03_PolimorfismoEmployee.Entities;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace ExemploOO03_PolimorfismoEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of emplyees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("OutSourced (y/n)? ");
                char OutSourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Hours: ");
                int Hours = int.Parse(Console.ReadLine());
                Console.Write("ValuePerHour: ");
                double ValuePerHour = double.Parse(Console.ReadLine(), ci);
                if (OutSourced.Equals('y') || OutSourced.Equals('Y'))
                {
                    Console.Write("Additional charge: ");
                    double Additional = double.Parse(Console.ReadLine(), ci);
                    OutSourcedEmployee sourcedEmployee = new OutSourcedEmployee(Name, Hours, ValuePerHour, Additional);
                    list.Add(sourcedEmployee);
                    Console.WriteLine();
                }
                else
                {
                    Employee employ = new Employee(Name, Hours, ValuePerHour);
                    list.Add(employ);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("f2", ci)}");
            }
        }
    }
}
