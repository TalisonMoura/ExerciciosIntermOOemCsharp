using ExemploOO07_ExcecoesPersoReservation2.Entities;
using ExemploOO07_ExcecoesPersoReservation2.Entities.Exceptions;

namespace ExemploOO07_ExcecoesPersoReservation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-In date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch(FormatException e) 
            {
                Console.WriteLine($"Format Error: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Unexpected Erros: {e.Message}");
            }
        }
    }
}