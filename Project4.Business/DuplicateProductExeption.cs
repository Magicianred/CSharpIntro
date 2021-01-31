using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public class DuplicateProductExeption:Exception
    {
        public DuplicateProductExeption(string message):base(message)
        {

        }
    }
}
