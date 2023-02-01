using ExercicioOO08_InterfaceContract.Entities;
using ExercicioOO08_InterfaceContract.Services;
using System.Globalization;

namespace ExercicioOO08_InterfaceContract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime Date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",ci);
            Console.Write("Contract Value: ");
            double ContractValue = double.Parse(Console.ReadLine(), ci);
            Console.Write("Enter the number of installments: ");
            int Installments = int.Parse(Console.ReadLine());

            Contract ct = new Contract(Number,Date,ContractValue);
            
            ContractService cs = new ContractService(new PayPalService());
            cs.ContractProcess(ct, Installments);

            Console.WriteLine();
            Console.WriteLine("Installments: ");
            foreach (Installment installment in ct.installmentsList)
            {
                Console.WriteLine(installment);
            }            
        }
    }
}