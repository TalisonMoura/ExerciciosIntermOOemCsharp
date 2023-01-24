using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO04_Product.Entities
{
    internal class UsedProduct : Product
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public DateTime Manufacture { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacture) : base(name,price) 
        {
            Manufacture = manufacture;
        }
        public override string PriceTag()
        {
            return ($"{Name} (Used) $ {Price.ToString("f2", ci)} (Manufacture date: {Manufacture.ToString("dd/MM/yyyy")})");
        }
    }
}
