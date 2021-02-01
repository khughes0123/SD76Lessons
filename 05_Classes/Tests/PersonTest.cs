using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Tests
{   [TestClass]
   public class PersonTest
    {

        [TestMethod]
        public void MyTestMethod()
        {
            Person person = new Person();
            person.FirstName = "Andrew";
            person.LastName = "Torr";
            person.DateOfBirth = new DateTime(1985, 9, 22);
            Console.WriteLine($"{person.FirstName} {person.LastName}, age {person.Age}");

            Console.WriteLine(person.DateOfBirth);

            
            Person otherPerson = new Person(
                "Ashley",
                "Lawrence",
                new DateTime(1989, 4, 26),
                new Vehicle("Chevy", "Malibu", VehicleType.Car)
                );

            Console.WriteLine(otherPerson.FullName);
            Console.WriteLine("make:" + otherPerson.Vehicle.Make);
            // otherPerson.FirstName = "Ash";
        }

        [TestMethod]
        public void IdTest()
        {
            for (int i=0; i<10; i++)
            {
                User user = new User("dsfh");
            }
        }
    }
}
