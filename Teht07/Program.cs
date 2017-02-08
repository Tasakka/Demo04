using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Sporty sporty = new Sporty("Perkka Virtanen", "Male", 20, "Hockey", 2);
            Console.WriteLine(sporty.ToString());
            Neardy neardy = new Neardy("Eino Löppönen", "Male", 21, "CS:GO", 16);
            Console.WriteLine(neardy.ToString());
        }
    }
}
