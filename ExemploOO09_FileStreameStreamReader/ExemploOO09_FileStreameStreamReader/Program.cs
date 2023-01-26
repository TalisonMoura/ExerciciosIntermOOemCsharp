namespace ExemploOO09_FileStreameStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESSA FORMA DE LEITURA É MAIS CLEAN, E É FEITA ATRAVES DO "FILE", O QUAL A INSTANCIAÇÃO DOS OBJETOS É AUTOMATICA.
            string path = @"C:\temp\File1.txt";
            StreamReader sr = null;
            
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error accurred: {e.Message}");
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            
            /*
            string path = @"C:\temp\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            string path = @"C:\temp\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;                                             OUTRA FORMA DE FAZER LEITURA DE ARQUIVO POR MEIO DO
                                                                                FILESTREAM E STREAMREADER.
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

            catch (IOException e)
            {
                Console.WriteLine($"An error accurred: {e.Message}");
            }
            finally
            {
                if(sr != null) sr.Close();
                if(fs != null) fs.Close();
            }
             
           */
        }
    }
}