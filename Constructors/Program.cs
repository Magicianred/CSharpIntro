using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer(2 , "Elif","Hatunoglu","Ankara");
           
        }
    }

    class Customer
    {
        public Customer()
        {
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
