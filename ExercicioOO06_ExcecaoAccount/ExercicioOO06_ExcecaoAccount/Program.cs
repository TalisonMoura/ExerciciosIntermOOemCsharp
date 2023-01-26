using ExercicioOO06_ExcecaoAccount.Entities;
using ExercicioOO06_ExcecaoAccount.Entities.Exceptions;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioOO06_ExcecaoAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string Holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double Balance = double.Parse(Console.ReadLine(), ci);
            Console.Write("WithDraw Limit: ");
            double WithDrawLimit = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine();

            Account account = new Account(Number, Holder, Balance, WithDrawLimit);

            Console.Write("Enter the amount for WithDraw: ");
            double Amount = double.Parse(Console.ReadLine(), ci);
            try
            {
                account.WithDraw(Amount);
                Console.Write($"New Balance: {account.Balance.ToString("f2", ci)}");
                Console.WriteLine();
            }
            catch (DomainException e)
            {
                Console.WriteLine($"WithDraw Error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected Error: {e.Message}");
            }
        }
    }
}