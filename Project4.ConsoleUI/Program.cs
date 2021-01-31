using System;
using Project4.Business;
using Project4.ConsoleUI;
using Project4.DataAccess;
using Project4.Entities;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new XProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            try
            {
                productManager.Add(new Product
                {
                    ProductId = 10,
                    ProductName = "Laptop",
                    QuantityPerUnit = "4Ayaklı masa",
                    UnitPrice = 1000,
                    UnitsInStock = 4
                });
            }
            catch (DuplicateProductExeption exeption)
            {

                Console.WriteLine(exeption.Message);
            }

        }
    }
}
