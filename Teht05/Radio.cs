using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Radio
    {
        public bool OnOff { get; set; }
        public int Volume { get; set; }
        public double Freq { get; set; }

        public void Power(bool Switch)
        {
            OnOff = Switch;
        }
        public void Frequency(double value)
        {
            if (value <= 26000 && value >= 2000)
            {
                Freq = value;
            }
            else
            {
                Console.WriteLine("The frequency is out of range.");
            }
        }
        public void RadioVolume (int vol)
        {
            if (vol <= 9 && vol >= 0)
            {
                Volume = vol;
            }
            else
            {
                Console.WriteLine("The volume is out of range.");
            }
        }
        public void PrintData()
        {
            Console.WriteLine("Power: " + OnOff);
            Console.WriteLine("Frequency: " + Freq);
            Console.WriteLine("Volume: " + Volume);
        }
    }
}
