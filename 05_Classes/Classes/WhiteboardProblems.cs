using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    class WhiteboardProblems
    {
        public string CombineStrings(string stringOne, string stringTwo)
        {
            return stringOne + " " + stringTwo;
        }
        //or No parameters, no return value, just console

        public void CombineStrings()
        {
            string stringOne = Console.ReadLine();
            string stringTwo = Console.ReadLine();
            Console.WriteLine(stringOne + " " + stringTwo);
        }
        // Both are "output"
        // Parameters and Console.Readline () are both input

        public double GetSmaller(double firstNumber, double secondNumber)
        {
            return firstNumber < secondNumber ? firstNumber : secondNumber;
            /* if (firstNumber < secondNumber)
             {
                 return firstNumber;
             }else
             {
                 return secondNumber;
             }
         }   */
        }

        public void WriteProduct(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        public bool IsWeekEnd(string dayOfWeek)
        {
            // string dayofWeek = "Monday";
            switch (dayOfWeek)
            {
                case "Saturday":
                case "Sunday":
                    return true;
                    // don't need to break because we return
                    // break ends the switch case
                    // return ends the whole method
                    // break;
                default:
                    return false;
            }
        }
    }
}

