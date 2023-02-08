using ExercicioOO13_LambdaEmployee.Entities;
using System.Globalization;

namespace ExercicioOO13_LambdaEmployee
{
    internal class Program
    { //C:\temp\InLambda1.txt
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Enter the file full path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] file = sr.ReadLine().Split(',');
                        string name = file[0];
                        string email = file[1];
                        double salary = double.Parse(file[2], ci);
                        employees.Add(new Employee(name, email, salary));
                    }
                }
                Console.Write("Enter the salary: ");
                double limit = double.Parse(Console.ReadLine(), ci);

                var emails = employees.Where(p => p.Salary > limit).OrderBy(p => p.Email).Select(P => P.Email);
                Console.WriteLine($"E-mail of people whose salary is more than {limit.ToString("f2", ci)}:");
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }
                var sum = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("f2", ci)}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred {e.Message}");
            }
        }
    }
}