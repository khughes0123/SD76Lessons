using _06_InheritanceClasses.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_InheritanceClasses
{
    [TestClass]
    public class PeopleTests
    {
        [TestClass]
        public class CustomerTests
        {
            [TestMethod]
            public void CustomersAndUsers()
            {
                User user = new User("fake@email.com", "Employee");
                Customer customer = new Customer("notReal@fakeEmail.biz");

                // user.SetFirstName("Ross");
                // user.SetLastName("Denman");

                customer.SetFirstName("Zuri");
                customer.SetLastName("Rojas");

                Console.WriteLine("User:");
                Console.WriteLine(user.ID);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.Name);
                Console.WriteLine("Customer:");
                Console.WriteLine(customer.ID);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Name);

            }
            [TestMethod]
            public void MyTestMethod()
            {


                string first = "My name is ";
                string second = "Kyle";
                Console.WriteLine(first + second);
}
        }
        }
    }