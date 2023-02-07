﻿using ExemploOO26_DelegatesRemoveAll.Entities;
namespace ExemploOO26_DelegatesRemoveAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 500.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductCheck);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        public static bool ProductCheck(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}