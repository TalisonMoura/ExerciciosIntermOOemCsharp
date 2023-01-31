using ExemploOO14_Service.Entities;
using ExemploOO14_Service.Services;
using System.Globalization;

namespace ExemploOO14_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter rental data: ");
            Console.Write("Car Model: ");
            string Model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime Start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", ci);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime Finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", ci);

            Console.Write("Enter price per hour: ");
            double Hour = double.Parse(Console.ReadLine(), ci);
            Console.Write("Enter price per day: ");
            double Day = double.Parse(Console.ReadLine(), ci);
            
            CarRental cr = new CarRental(Start, Finish,new Vehicle(Model));

            RentalService rentalService = new RentalService(Hour, Day, new BrazilTaxService());

            rentalService.ProcessInvoice(cr);
            Console.WriteLine();
            Console.WriteLine("INVOICE:");
            Console.WriteLine(cr.Invoice);
        }
    }
}