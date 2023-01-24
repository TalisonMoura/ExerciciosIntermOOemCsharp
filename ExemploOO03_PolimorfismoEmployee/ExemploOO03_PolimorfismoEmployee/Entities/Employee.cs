using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO03_PolimorfismoEmployee.Entities
{
    internal class Employee
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }


        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
