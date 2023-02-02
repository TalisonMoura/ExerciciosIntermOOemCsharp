using ExemploOO15_HerdarVSCumprirContrato.Model.Entities;
using ExemploOO15_HerdarVSCumprirContrato.Model.Enums;

namespace ExemploOO15_HerdarVSCumprirContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine(s2);
        }
    }
}