using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO05_Taxpayer.Entities
{
    internal abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        
        public Taxpayer() { }

        public Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double TaxCalculate();
    }
}
