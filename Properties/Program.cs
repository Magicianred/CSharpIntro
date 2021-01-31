using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1; // Setter çalışıyor. Yazma
            Console.Write(product.Id); // Getter çalışır. Okuma
            product.UnitInStock = 50;
            Console.WriteLine(product.UnitInStock);
            product.UniPrice = 500;
            Console.WriteLine(product.UniPrice);
            

        }
    }

    class Product
    {   //Field
        decimal _unitPrice;
        // Auto implemented property
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal UniPrice { 
            get { return _unitPrice + _unitPrice * 18 / 100; } 
            set { _unitPrice = value; } 
        }

        public decimal UnitInStock;

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


    }
}
