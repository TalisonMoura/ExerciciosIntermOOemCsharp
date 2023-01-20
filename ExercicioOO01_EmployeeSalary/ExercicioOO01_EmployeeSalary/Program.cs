using ExercicioOO01_EmployeeSalary.Entities;
using ExercicioOO01_EmployeeSalary.Entities.Enums;
using System.Globalization;

namespace ExercicioOO01_EmployeeSalary

{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;


            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), ci);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), ci);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hours);
                worker.AddContract(contract);
                Console.WriteLine();
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: R$ {worker.Income(year, month).ToString("f2",ci)}");
        }
    }
}