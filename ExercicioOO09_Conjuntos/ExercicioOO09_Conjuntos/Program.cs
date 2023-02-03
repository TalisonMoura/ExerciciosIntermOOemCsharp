using ExercicioOO09_Conjuntos.Entities;

namespace ExercicioOO09_Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> lr = new HashSet<LogRecord>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instante = DateTime.Parse(line[1]);
                        lr.Add(new LogRecord { UserName = name, Instant = instante }); // FORMA DE INSTANCIA SEM O CONTRUTOR NA CLASSE LOGRECORD.
                    }
                    Console.WriteLine($"Total users: {lr.Count}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}