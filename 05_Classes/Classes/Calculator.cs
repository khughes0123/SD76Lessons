using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Calculator
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
      
        
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            return sum;

        }
        // overload:

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        public int Subtract(int numOne, int numTwo)
        {
            int difference = numOne - numTwo;
            return difference;
        }

        public double Divide(int numOne, int numTwo)
        {
            //return (double) numOne / numTwo;
            double numOneDouble = Convert.ToDouble(numOne);
            double numTwoDouble = Convert.ToDouble(numTwo);
            double quotient = numOneDouble / numTwoDouble;
            return quotient;
        }

        public double Add(string numStringOne, string numStringTwo)
        {
            Console.WriteLine("Add method: " + numStringOne, " " + numStringTwo);
            // double numOne = Double.Parse(numStringOne);

            Console.WriteLine(numStringOne);
            double numOne = Convert.ToDouble(numStringOne);
            Console.WriteLine(numStringTwo);
            double numTwo = Convert.ToDouble(numStringTwo);
            return numOne + numTwo;

        }


    }
}
