using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 35;
            bool equals = age == 42;
            Console.WriteLine("Am I 42?" + equals);

            string name = "Andrew";
            Console.WriteLine(name == "Jacob");

            bool notEqual = age != 200;

            Console.WriteLine("I'm not two centuries old am I?" + notEqual);

            List<string> firstList = new List<string>();
            firstList.Add(name);
            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine("Are the lists exactly the same?" + listsAreEqual);

            bool amIAnAdult = age >= 18;

            bool amEighteen = age == 18;
            bool amOverEighteen = age > 18;

            amIAnAdult = amEighteen || amOverEighteen;

            bool hasMagenta = true;
            bool hasCyan = true;
            bool myFaveColors = hasMagenta && hasCyan;

            // XOR, NAND, NOR, XNOR <--not included, but interesting

        }
    }
}
