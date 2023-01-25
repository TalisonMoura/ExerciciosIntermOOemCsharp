using ExercicioOO05_Taxpayer.Entities;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ExercicioOO05_Taxpayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            List<Taxpayer> list = new List<Taxpayer>();

            Console.Write("Enter de number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or Company (i/c)? ");
                char tax = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double AnualIncome = double.Parse(Console.ReadLine(), ci);
                if (tax.Equals('i') || tax.Equals('I'))
                {
                    Console.Write("Health expenditures: ");
                    double HealthEx = double.Parse(Console.ReadLine(), ci);
                    list.Add(new TaxIndividual(Name, AnualIncome, HealthEx));
                    Console.WriteLine();
                }
                else if (tax.Equals('c') || tax.Equals('C'))
                {
                    Console.Write("Number of Employee: ");
                    int Number = int.Parse(Console.ReadLine());
                    list.Add(new TaxCompany(Name, AnualIncome, Number));
                    Console.WriteLine();
                }
                else
                {
                    i--;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("TAXES PAID");
            foreach (Taxpayer tx in list)
            {
                Console.WriteLine($"{tx.Name}: $ {tx.TaxCalculate().ToString("f2", ci)}");
            }
            Console.WriteLine();
            double sum = 0.0;
            foreach (Taxpayer tx in list)
            {
                sum += tx.TaxCalculate();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("f2", ci)}");
        }
    }
}