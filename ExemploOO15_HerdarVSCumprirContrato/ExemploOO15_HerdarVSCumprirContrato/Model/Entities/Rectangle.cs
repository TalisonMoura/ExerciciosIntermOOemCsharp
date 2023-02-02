using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO15_HerdarVSCumprirContrato.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return ($"Rectangle Color = {Color}\nWidth = {Width.ToString("f2", ci)}\nHeight = {Height.ToString("f2", ci)}\nArea = {Area().ToString("f2", ci)}");
        }
    }
}
