using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Tests
{
    [TestClass]
    public class GreeterTests
    {
        [TestMethod]
        public void MyTestMethod()
        
        {
        Greeter greeter = new Greeter();
                        // argument
        greeter.SayHello("Andrew");

        greeter.SayRandomGreeting("Ross");

        }

       
       

        
    
        
    }
}
