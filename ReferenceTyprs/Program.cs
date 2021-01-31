using System;

namespace ReferenceTyprs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            int sayi1 = 10;  // Sayı 1in değeri 10
            int sayi2 = 20;  // Sayı 2 nin değeri 20

            sayi1 = sayi2; // Sayı 1 in değeri sayı 2 nin değeri yani 20

            sayi2 = 100; // Sayı 2 nin değeri 100

            Console.WriteLine("Sayı 1: " + sayi1); // Sayı 1 in değeri 20 olarak döner.



            // Reference Types
            int[] sayilar1 = new int[] { 1, 2, 3 }; // sayilar 1 in adresi 101
            int[] sayilar2 = new int[] { 10, 20, 30 };// sayiler 2 nin adresi 202

            sayilar1 = sayilar2; //sayılar 1 adresi sayılar 2 nin adresi yani 202

            sayilar2[0] = 1000; //sayılar 2nin adresinin 0 indexli veriyi değiştiriyor.

            Console.WriteLine("Sayılar[0]: " + sayilar1[0]); // sayılar 1 in adresi 202 olduğundan 0 indexli verimiz 1000 oluyor.


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Kemal";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);




            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1235465498";

            Employee employee = new Employee();


            Person person3 = customer;
            customer.FirstName = "Ahmet";
            
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);


        }
    }

    // Base Class : Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
