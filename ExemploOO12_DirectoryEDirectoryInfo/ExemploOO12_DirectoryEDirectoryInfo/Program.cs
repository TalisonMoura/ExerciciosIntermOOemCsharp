namespace ExemploOO12_DirectoryEDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\MyFolder";

            try
            {
                // MANEIRA SIMPLIFICADA DE IENUMERABLE, A PROPRIA IDE FAZ A INFERÊNCIA DE TIPO.
                // var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); 
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string fo in folders)
                {
                    Console.WriteLine(fo);
                }
                var fiels = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FIELS:");
                foreach (string fi in fiels)
                {
                    Console.WriteLine(fi);
                }
                Directory.CreateDirectory(path + @"\NewFolder"); // OR Directory.CreateDirectory(@"C:\temp\MyFolder\NewFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}