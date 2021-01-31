using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        //List<Product> _products;
        public EfProductDal()
        {
            //_products = new List<Product>
            //{
            //    new Product{ProductId = 1,ProductName="Acer ef Bilgisayar",QuantityPerUnit="32gb Ram",UnitPrice=10000,UnitsInStock=2},
            //    new Product{ProductId = 2,ProductName="Asus ef Bilgisayar",QuantityPerUnit="32gb Ram",UnitPrice=10000,UnitsInStock=1},
            //    new Product{ProductId = 3,ProductName="Hp ef Bilgisayar",QuantityPerUnit="32gb Ram",UnitPrice=10000,UnitsInStock=0},
            //    new Product{ProductId = 4,ProductName="Mac ef Bilgisayar",QuantityPerUnit="32gb Ram",UnitPrice=10000,UnitsInStock=3},
            //    new Product{ProductId = 5,ProductName="Dell ef Bilgisayar",QuantityPerUnit="32gb Ram",UnitPrice=10000,UnitsInStock=10}
            //};
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
            // Dispose bellekten uçur. using içerisine yazarsak kullandıktan sonra hemen uçurur
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
