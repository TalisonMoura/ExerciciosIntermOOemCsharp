using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO30_Demo1LINQ.Entities
{
    internal class Product
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return ($"{Id}, {Name}, {Price.ToString("f2", ci)}, {Category.Name}, {Category.Tier}");
        }
    }
}
