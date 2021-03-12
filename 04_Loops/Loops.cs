using _11_IConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _04_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 0;

            while (total <100)
            {
                // total = total + 1;
                // total += 1;
                total++;
                Console.WriteLine("Total: " + total);
            }

            int number = 5;
            Console.WriteLine(++number);

            Random randy = new Random();
            for (int i =0; i !=7; i = randy.Next(0, 21))
            {
               
                if (i == 5)
                {
                    FunConsole console = new FunConsole("Ashley");
                    console.WriteLine("FIVE!!");
                }
                Console.WriteLine(i);
            }
            
        }

        [TestMethod]
        public void ForLoops()
        {
            string greeting = "hello world!";

            foreach (char letter in greeting)
            {
                Console.WriteLine(letter);
            }

            List<string> stringList = new List<string>();
            stringList.Add("hello");
            stringList.Add("world");
            stringList.Add("banana");

            foreach(string word in stringList)
            {
                Console.WriteLine(word);
            }

            for (int i = 0; i <100; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void LoopsChallenge()
        {
            string super = "Supercalifragilisticexpialidocious";
            int count = 0;

            foreach (char letter in super)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine("L");
                }
                else
                {
                    Console.WriteLine("Not 'i'");

                }

                
                

            }
            Console.WriteLine(super.Length);

            for (int i=0; i< super.Length; i++)
            {
                char letter = super[i];
                Console.WriteLine(super[i]);
            }
            

           

           
               

            

            

            
           
           


        }
        
    }
}
