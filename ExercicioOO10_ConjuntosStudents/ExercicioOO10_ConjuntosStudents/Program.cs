
namespace ExercicioOO10_ConjuntosStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            try
            {
                Console.Write("Hou many students for course A? ");
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    int cod = int.Parse(Console.ReadLine());
                    set.Add(cod);
                }
                
                Console.WriteLine("---------------------------------");
                Console.Write("Hou many students for course B? ");
                int b = int.Parse(Console.ReadLine());
                for (int i = 0; i < b; i++)
                {
                    int cod = int.Parse(Console.ReadLine());
                    set.Add(cod);
                }
                
                Console.WriteLine("---------------------------------");
                Console.Write("Hou many students for course C? ");
                int c = int.Parse(Console.ReadLine());
                for (int i = 0; i < c; i++)
                {
                    int cod = int.Parse(Console.ReadLine());
                    set.Add(cod);
                }
                
                Console.WriteLine();
                Console.Write($"Total students: {set.Count}");
                Console.WriteLine();
            
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}