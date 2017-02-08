using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Car", "Audi", 2016, "Black");
            Console.WriteLine("Vehicle: " + vehicle.ToString());
            Bike bike = new Bike("Jopo", "Street", 1970, "Green", false, "no");
            Console.WriteLine("Bike: " + bike.ToString());
            Boat boat = new Boat("Boterinjo", "Pro 1600", 1990, "White", "Rowboat", 6);
            Console.WriteLine("Boat: " + boat.ToString());
        }
    }
}
