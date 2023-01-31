using ExercicioOO07_Path.Entities;
using System.Data;
using System.Globalization;

namespace ExercicioOO07_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);
                
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";
                
                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], ci);
                        int quantity = int.Parse(fields[2]);
                        
                        Product product = new Product(name, price, quantity);

                        sw.WriteLine($"{product.Name}, {product.Price.ToString("f2",ci)}");
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