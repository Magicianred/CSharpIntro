﻿using System;
using System.Linq;

namespace EntityFramework_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ado.Net bir kütüphane verilere ulaşmak için kullanılan.
            // Entity Framework-- Bir ORM(Object Relational Mapping)
            // Alternatifleri == NHibernate, Dapper



            //GetAll();
            //GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
