using System;

namespace Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() {ProductName="Laptop",UnitPrice=5000,UnitsInStok=5 };
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }


}
