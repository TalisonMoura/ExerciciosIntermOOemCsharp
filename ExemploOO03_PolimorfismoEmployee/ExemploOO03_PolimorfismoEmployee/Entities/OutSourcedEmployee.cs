using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO03_PolimorfismoEmployee.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee() { }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            base.Payment();
            return Hours * ValuePerHour + (AdditionalCharge * 1.10);
        }
    }
}
