using ExemploOO16_HerançaMultiplaDiamante.Devices;

namespace ExemploOO16_HerançaMultiplaDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");
            
            Console.WriteLine();
            
            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My E-mail");
            Console.WriteLine(s.Scan());
            
            Console.WriteLine();
            
            ComboDevice cd = new ComboDevice() { SerialNumber = 3921 };
            cd.ProcessDoc("My dissertation");
            cd.Print("My dissertation");
            Console.WriteLine(cd.Scan());
        }
    }
}