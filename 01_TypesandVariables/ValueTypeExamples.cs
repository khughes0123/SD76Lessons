using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesandVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void TestMethod1()
        {
            //declare
            bool isDeclared;
            //initialize
            isDeclared = true;

            bool isDeclaredAndInitialized = true;
            isDeclaredAndInitialized = false;

        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char anotherChar = ';';
            char specialChar = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            // sbyte
            int intMin = -2147483648;
            int intMax = 2147483647;

            long longExample = 9223372036854775807;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.04523342567875656878551f;
            double doubleExample = 1.04523134257685474565d;
            decimal decimalExample = 1.045231342567874564745m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }
        enum PastryType { Cake =20, Cupcake, Eclaire, Croissant, Danish, Baguette}
        [TestMethod]
        public void Enums()
        {
            PastryType pastryType = PastryType.Baguette;
            PastryType anotherOne = PastryType.Cake;

            Console.WriteLine((int) pastryType);
            Console.WriteLine((int) anotherOne);
        }

        [TestMethod]
        public void Structs ()

        {
            Int32 age = 35;

            DateTime today = DateTime.Now;

            DateTime birthdate = new DateTime(1985, 09, 22);

            Console.WriteLine(birthdate);

            TimeSpan myAge = today - birthdate;

            Console.WriteLine(today - birthdate);
        }
    }
}
