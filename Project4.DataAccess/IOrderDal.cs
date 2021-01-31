using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public interface IOrderDal : IEntityRepository<Order>
    {
    }
}
