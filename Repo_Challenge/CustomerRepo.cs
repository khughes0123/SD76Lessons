using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Challenge
{
    class CustomerRepo
    {
        private readonly List<Customer> _customers;
        // CRUD

       
        public void AddCustomer(string LastName, DateTime birthDate)
        {
            _customers.Add(new Customer(LastName, birthDate));
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public Customer GetCustomerById( int id)
        {
            foreach (Customer customer in _customers)
                {
                if (customer.CustomerId == id)
                {
                    return customer;
                }
            }
            return null;

            // LINQ
            // This one line does the exact same thing as the above lines
            return _customers.SingleOrDefault(customer => customer.CustomerId == id);

            // Another example - get all customers over 40
            _customers.Where(customer => customer.Age >= 40);
        }
    }
}
