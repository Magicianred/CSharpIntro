using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifers
{
    public class House
    {
        public House()
        {

        }
        public int Id { get; set; }
        public string MyProperty { get; set; }

        protected string Suburb { get; set; }

    }

   

}
