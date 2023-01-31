using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO14_Service.Entities
{
    internal class Invoice
    {
        CultureInfo ci = CultureInfo.InvariantCulture;

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get{ return BasicPayment + Tax; }
        }
        public override string ToString()
        {
            return ($"Basic Payment: {BasicPayment.ToString("f2", ci)}\nTax: {Tax.ToString("f2", ci)}\nTotal Payment: {TotalPayment.ToString("f2", ci)}");
        }
    }
}
