using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1,CategoryName="Bilgisayar"},
                new Category{CategoryId = 2,CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product {ProductId =1, CategoryId =1,PropductName="Acer Laptop",QuantityPerUnit="32Gb",UnitPrice=10000,UnitsInStock=5},
                new Product {ProductId =2, CategoryId =1,PropductName="Asus Laptop",QuantityPerUnit="16Gb",UnitPrice=8000,UnitsInStock=3},
                new Product {ProductId =3, CategoryId =1,PropductName="Hp Laptop",QuantityPerUnit="8Gb",UnitPrice=6000,UnitsInStock=2},
                new Product {ProductId =4, CategoryId =2,PropductName="Samsung",QuantityPerUnit="4Gb",UnitPrice=5000,UnitsInStock=15 },
                new Product {ProductId =5, CategoryId =2,PropductName="Apple",QuantityPerUnit="4Gb",UnitPrice=8000 ,UnitsInStock=0}
            };

            //Test(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where  p.UnitPrice>5000
                         orderby p.UnitPrice descending
                         select new ProductDto
                         {
                             ProductId = p.ProductId,
                             CategoryName = c.CategoryName,
                             ProductName = p.PropductName,
                             UnitPrice = p.UnitPrice
                         };
            foreach (var productDto in result)
            {
                //Console.WriteLine(productDto.ProductName + " " + productDto.CategoryName);
                Console.WriteLine("{0} --- {1}",productDto.ProductName,productDto.CategoryName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.PropductName.Contains("Top")).OrderBy(p => p.UnitPrice).ThenByDescending(x => x.PropductName);

            foreach (var product in result)
            {
                Console.WriteLine(product.PropductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.PropductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(x => x.PropductName == "Acer");

            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.PropductName);
                }
            }

            Console.WriteLine("Linq---------------------------");

            var result = products.Where(p => p.UnitsInStock > 5000 && p.UnitsInStock > 3);

            foreach (var item in result)
            {
                Console.WriteLine(item.PropductName);
            }
        }

        //static List<Product> GetProducts(List<Product> products)
        //{
        //    return products.Where(p => p.UnitsInStock > 5000 && p.UnitsInStock > 3).ToList();
        //}

    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string CategoryName { get; set; }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string PropductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
