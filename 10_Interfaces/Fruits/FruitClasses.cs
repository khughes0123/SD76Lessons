using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Fruits
{
    public class Banana : IFruit
    {

        // Arrow notation - super shorthand for returning a value like in a method that you can use in a few specific places
        public string Name => "Banana";
        //public string Name {get;} = "Banana"

        public bool IsPeeled { get; private set; } = false;

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the banana";
        }
    }

    public class Orange : IFruit
    {
        public bool IsPeeled { get; private set; }

        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        // public string Name => "Orange";  -  does same thing as getter
        // public string Name {get;} = "Orange"; --- does same thing as getter
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Peel()
        {
            if (IsPeeled)
            {
                //throw new Exception("It's already been peeled!");
                return "This orange has already been peeled!";
            }

            IsPeeled = true;
            return $"You peel the {GetType().Name}";
        }

        public string Squeeze()
        {
            return "You get orange juice!";
        }
    }

    public class Mandarin : Orange
    {
        public Mandarin(bool isPeeled) : base(isPeeled) { }
    }

    public class Grape : IFruit
    {
        // The getter always returns "Grape"

        public string Name => "Grape";
        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            //throw new Exception("why would you do that?");
            return "who peels grapes?";
        }
    }

    public class Apple : IFruit
    {
        public string Name => "Apple";

        public string Color => "Green";

        public bool IsPeeled { get; private set; } = false;

        public bool IsRotten { get; private set; }

        public string Peel()
        {
           
            return "Just eat it!";
        }

        public string ThrowItAway()
        {
            IsRotten = true;
            return "Throw it away!";
        }
    }
}



// CHALLENGE:

// Create your own member of the IFruit interface, 
//with its own unique implementation of Peel()
  //  and one each additional property and method

