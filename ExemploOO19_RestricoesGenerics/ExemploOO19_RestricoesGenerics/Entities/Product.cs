using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO19_RestricoesGenerics.Entities
{
    internal class Product : IComparable
    {
        CultureInfo ci  = CultureInfo.InvariantCulture;
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return ($"{Name},{Price.ToString("f2", ci)}");
        }
        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Compraring erro: argument is not a product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
