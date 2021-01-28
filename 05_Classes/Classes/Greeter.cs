using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Greeter
    {
        Random _random = new Random();

        public void SayHello(string name)

        {

            Console.WriteLine($"Hello, { name}!");
        }

        public void SayRandomGreeting(string name)
        {
            Console.WriteLine($"{GetRandomGreeting()},{name}");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        private string GetRandomGreeting()
        {
            string[] greetings = new string[] { "Hi", "yo", "whats up", "how are you", "guten Tag", "bonjour" };
            int randomNumber = _random.Next(0, greetings.Length);
            string randomGreeting = greetings.ElementAt(randomNumber);
            // string randomGreeting = greetings[randomNumber];
            return randomGreeting;
        }
    }


}
