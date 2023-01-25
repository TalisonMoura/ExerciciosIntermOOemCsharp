using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO05_Taxpayer.Entities
{
    internal class TaxIndividual : Taxpayer
    {

        public double HealthExpenditures { get; set; }

        public TaxIndividual() { }

        public TaxIndividual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double TaxCalculate()
        {
            double sum = 0.0;
            if (AnualIncome < 20000.00)
            {
                sum = AnualIncome * 0.15 - (HealthExpenditures * 0.50); ;
            }
            else 
            {
                sum = AnualIncome * 0.25 - (HealthExpenditures * 0.50);
            }
            return sum;
        }
    }
}
