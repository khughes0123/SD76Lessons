﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_IConsole
{
    public class FunConsole : IConsole
    {

        private Random _random = new Random();

        private string _name;

        public FunConsole(string name)
        {
            _name = name;
        }
        public ConsoleColor PickRandomColor()
        {
            int choice = _random.Next(0, 6);
            switch (choice)
            {
                case 0:
                    return ConsoleColor.Red;
                case 1:
                    return ConsoleColor.Blue;
                case 2:
                    return ConsoleColor.Green;
                case 3:
                    return ConsoleColor.Yellow;
                case 4:
                    return ConsoleColor.Magenta;
                case 5:
                    return ConsoleColor.Cyan;
                default: return ConsoleColor.White;
            }
        }
        public void Clear()
        {
            Console.Clear();
            WriteLine("The screen is now blank");
        }

        public ConsoleKeyInfo ReadKey()
        {
            throw new NotImplementedException();
        }

        public string ReadLine()
        {
            throw new NotImplementedException();
        }

        public void Write(string s)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string s)
        {
            Console.BackgroundColor = PickRandomColor();
            Console.ForegroundColor = PickRandomColor();

            if (_random.Next(0,3) == 0)
            {
                Console.WriteLine(s.ToUpper());
            }else
            {
                Console.WriteLine(s.ToLower());
            }

            Thread.Sleep(50);
        }

        

        public void WriteLine(object o)
        {
            throw new NotImplementedException();
        }
    }
}
