using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO04_Product.Entities
{
    internal class ImportedProduct : Product
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
        public override string PriceTag()
        {
            return ($"{Name} $ {TotalPrice().ToString("f2", ci)} (Customs Fee: $ {CustomsFee.ToString("f2",ci)})");
        }
    }
}
