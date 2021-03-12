using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Komodo_Insurance
{
   public interface IVehicles
    {
        string Make{ get; }
        string Model { get; }
        string Color { get; }
        bool On { get; }
        bool Off { get; }
        bool Drive { get; }

        string TurnCarOn();

        string TurnCarOff();
    }
}
