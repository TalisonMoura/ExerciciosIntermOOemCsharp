namespace ExemploOO11_StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourcepath = @"C:\temp\File1.txt"; // ARQUIVO DE ORIGEM
            string targetpath = @"C:\temp\File2.txt"; // ARQUIVO DE DESTINO  

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}