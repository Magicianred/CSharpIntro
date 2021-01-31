using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName == "Laptop")
            {
                throw new DuplicateProductExeption("Laptop ekleyemezsiniz");
            }
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            // İş kodları yazılır.
            return _productDal.GetAll();
        }
    }
}
