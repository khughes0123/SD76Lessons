using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void Volume()
        {
            Room closet = new Room(5, 1, 5);
            Console.WriteLine("closet SurfaceArea: " + closet.SurfaceArea);
            Console.WriteLine("closet Volume:" + closet.Volume);
            

            
        }
    }
}
