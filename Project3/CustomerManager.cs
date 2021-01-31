using System.Collections.Generic;

namespace Project3
{
    public class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id = 1,FirstName="Kemal",LastName="Hatunoglu",City="Ankara",Email="Kemal@"},
                new Customer{Id = 1,FirstName="Elif",LastName="Hatunoglu",City="İstanbul",Email="Elif@"},
                new Customer{Id = 1,FirstName="Tito",LastName="Hatunoglu",City="İzmir",Email="Tito@"},
                new Customer{Id = 1,FirstName="Hoppa",LastName="Hatunoglu",City="Ankara",Email="Hoppa@"}
            };

        }

        List<Customer> customers;

        public List<Customer> GetAll()
        {
            // Veritabanına bağlanıp o müşterileri tolist yöntemi ile çekeriz.
        
            return customers;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
