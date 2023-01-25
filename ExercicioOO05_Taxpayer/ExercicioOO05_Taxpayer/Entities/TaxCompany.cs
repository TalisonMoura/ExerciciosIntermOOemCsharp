using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO05_Taxpayer.Entities
{
    internal class TaxCompany : Taxpayer
    {
        public int NumberOfEmplyee { get; set; }

        public TaxCompany() { }

        public TaxCompany(string name, double anualIncome, int numberOfEmplyee) : base(name,anualIncome)
        {
            NumberOfEmplyee = numberOfEmplyee;
        }
        public override double TaxCalculate()
        {
            double sum = 0.0;
            if(NumberOfEmplyee > 10)
            {
                sum = AnualIncome * 0.14;
            }
            else
            {
                sum = AnualIncome * 0.16;
            }
            return sum;
        }
    }
}
