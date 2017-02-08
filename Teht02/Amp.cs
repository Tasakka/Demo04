using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Amp
    {
        private int volume = 0;
        private int maxvolume = 100;
        private int minvolume = 0;
        
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= minvolume && value <= maxvolume)
                {
                    volume = value;
                }
                    if (volume == maxvolume)
                {
                    Console.WriteLine("Volume is se to max");
                }
                    if (volume == minvolume)
                {
                    Console.WriteLine("Volume is set to min");
                }
                else if (value > maxvolume)
                {
                    Console.WriteLine("CAN'T GO ANY HIGHER!");
                    volume = maxvolume;
                }
                else if (value < minvolume)
                {
                    Console.WriteLine("Can't go any lower.");
                    volume = minvolume;
                }
            }
        }
    }
}
