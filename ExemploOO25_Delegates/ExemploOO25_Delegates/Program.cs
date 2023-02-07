using ExemploOO25_Delegates.Services;

namespace ExemploOO25_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperationMult(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            double result = op(a, b);
            Console.WriteLine(result);
            
            Console.WriteLine("----------------------------------------");

            BinaryNumericOperationMult opm = CalculationService.ShowSum;
            opm += CalculationService.ShowMax;
            opm(a, b);
        }
    }
}