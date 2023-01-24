using ExemploOO04_MetodosAbstratos.Entities;
using ExemploOO04_MetodosAbstratos.Entities.Enums;
using System.Globalization;
using System.Xml;

namespace ExemploOO04_MetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            List<Shape> list = new List<Shape>();


            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1}");
                Console.Write("Rectangle or Ciecle (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch.Equals('r') || ch.Equals('R'))
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), ci);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), ci);
                    Rectangle rec = new Rectangle(width, height, color);
                    list.Add(rec);
                    Console.WriteLine();
                }
                else if (ch.Equals('c') || ch.Equals('C'))
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), ci);
                    Circle cir = new Circle(radius, color);
                    list.Add(cir);
                    Console.WriteLine();
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("f2", ci));
            }
        }
    }
}