namespace ExemploOO10_BlocoUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AMBOS OS CODIGOS FAZER A MESMA EXECUÇÃO, A DIFERENÇA ENTRE O PRIMEIRO PARA O SEGUNDO É A FORMA MAIS CLEAN DE ESCREVE-LO, 
            //  E O PRIMEIRO CÓDIGO É FEITA A INSTANCIAÇÃO DIRETAMENTE PELO "FILE", ENQUANTO A SEGUNGA É NECESSARIO INSTANCIAR O FILESTREAM E O STREAMREADER.
            // *******SINTAXE SIMPLIFICADA QUE GARANTE QUE OS OBJETOS IDISPOSABLE SERÃO FECHADOS TIPO(FONT,FILESTREAM,STREAMREADER,STREAMWRITER)******

            string path = @"C:\temp\File1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            /*
             try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            */
        }
    }
}