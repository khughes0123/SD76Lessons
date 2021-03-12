using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Komodo_Insurance
{
    public class Sedan : IVehicles
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public bool On { get; private set; }

        public bool Off { get; private set; }

        public bool Drive => true;

        public string TurnCarOn()
        {
            if (On)
            {
                return "The vehicle is on";
            }
            else
            {
                On = false;
                return "Turn the vehicle on";
            }
        }

        public string TurnCarOff()
        {
            if (Off)
            {

                return "The vehicle is off";
            }
            else
            {
                Off = false;
                return "Turn the vehicle off";
            }
        }
    }
    public class SUV : IVehicles
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public bool On { get; private set; }

        public bool Off { get; private set; }

        public bool Drive => true;

        public string TurnCarOn()
        {
            if (On)
            {
                return "The vehicle is on";
            }
            else
            {
                On = false;
                return "Turn the vehicle on";
            }
        }

        public string TurnCarOff()
        {
            if (Off)
            {

                return "The vehicle is off";
            }
            else
            {
                Off = false;
                return "Turn the vehicle off";
            }
        }
    }
}
