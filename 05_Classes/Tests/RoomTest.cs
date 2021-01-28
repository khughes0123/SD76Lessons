using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Room room = new Room();
            room.length = 5;
            room.width = 1;
            room.height = 5;

            Console.WriteLine(room.length);
            Console.WriteLine(room.width);
            Console.WriteLine(room.height);

        }
    }
}
