using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Room
    {
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public int SurfaceArea
        
        {
            get
            {
                int topandBottom = 2 *
                return (
                    2 * length * width +
                    2 * length * height +
                    2 * width * height

                    );
            }
        }
    }
}
