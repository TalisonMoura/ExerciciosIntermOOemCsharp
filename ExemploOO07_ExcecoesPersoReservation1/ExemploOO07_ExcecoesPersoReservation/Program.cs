using ExemploOO07_ExcecoesPersoReservation.Entities;
namespace ExemploOO07_ExcecoesPersoReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // TRATAMENTO DE EXCECAO COM METODOS E FUNCOES SEM BOAS PRATICAS, SEMANTICA SOBRECARREGADA
            // TRATAMENTO REALIZADO COM METODOS RETORNANDO STRING, E LÓGICA ANINHADA. FORA DAS BOAS PRATICAS.
            

            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in Reservation: Check-Out date must be after Check-In!");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine($"Error in reservation: {error}");
                }
                else
                {
                    Console.WriteLine($"Reservation: {reservation}");
                }
            }
        }
    }
}