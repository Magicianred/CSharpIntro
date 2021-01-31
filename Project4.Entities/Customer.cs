using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Entities
{
   public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string ContactName { get; set; }
    }
}
