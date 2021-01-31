using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_2
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            string value = product.ProductName + " Ürün sisteme eklendi.";
            Console.WriteLine(value);
        }
    }
}
