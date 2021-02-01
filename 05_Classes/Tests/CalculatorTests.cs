using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calc = new Calculator();

            Console.WriteLine(3.0/5.0); ;
            Console.WriteLine(calc.Divide(3,5)); ;

        }

        
        }
    }
}
