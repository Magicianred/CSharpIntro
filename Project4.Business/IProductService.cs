using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);

    }
}
