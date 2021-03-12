using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that takes in a number and writes out every number from 1 until the given number
            // if the number is divisible by 3 write fizz instead
            // if divisible 5 write buzz
            // if number divisible by both write fizzbuzz instead

            // Method Call
            FizzBuzz(15);
            // FizzBuzz(145);
            Greeting("Class");
        }

        public static void Greeting (string andrew)
        {
            Console.WriteLine($"Hello {andrew}");
        }
        public static void FizzBuzz (int x) 
        {
            for (int i = 1; i <= x; i++)
            {
                if(i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Noun = object
        // Adj = properties
        // verbs = methods
    }
}
