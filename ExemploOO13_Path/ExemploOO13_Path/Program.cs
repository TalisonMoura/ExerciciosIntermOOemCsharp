namespace ExemploOO13_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\temp\MyFolder\File1.txt.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // FUNÇÃO PARA VERIFICAR CARACTER DE SEPARAÇÃO.
            Console.WriteLine("PathSeparator: " + Path.PathSeparator); // FUNÇÃO PARA VERIFICAR CARACTER DE SEPARAÇÃO DE PASTA.
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // FUNÇÃO PARA VERIFICAR O ENDEREÇO DA PASTA.
            Console.WriteLine("GetFileName: " + Path.GetFileName(path)); // FUNÇÃO PARA VERIFICAR O NOME DO ARQUIVO E SUA EXTENSÃO.
            Console.WriteLine("GetExtension: " + Path.GetExtension(path)); // FUNÇÃO PARA VERIFICAR SOMENTE A EXTENSÃO DO ARQUIVO.
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // FUNÇÃO PARA VERIFICAR O NOME DO ARQUIVO SEM A EXTENSÃO DO MESMO.
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); // FUNÇÃO PARA VERIFICAR O NOME COMPLETO DO ARQUIVO E SUA EXTENSÃO.
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); // FUNÇÃO PARA VERIFICAR PASTA TEMPORARIA DO SISTEMA.
        }
    }
}