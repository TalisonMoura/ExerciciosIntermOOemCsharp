using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO15_HerdarVSCumprirContrato.Model.Entities
{
    internal class Circle : AbstractShape
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return ($"Circle Color = {Color}\nRadius = {Radius.ToString("f2", ci)}\nArea = {Area().ToString("f2", ci)}");
        }
    }
}
