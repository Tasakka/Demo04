using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Teht05.Radio();
            radio.OnOff = true;
            radio.Frequency(2505.5);
            radio.RadioVolume(8);
            radio.Frequency(99999);
            radio.RadioVolume(11);
            radio.PrintData();
        }
    }
}
