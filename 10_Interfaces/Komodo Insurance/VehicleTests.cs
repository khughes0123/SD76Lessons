using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Interfaces.Komodo_Insurance
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void CreateNewSedanTest(string color, string make, string model)
        {
            Sedan sedanOne = new Sedan();
            sedanOne.Color = color;
            sedanOne.Make = make;
            sedanOne.Model = model;

        }
    }
}
