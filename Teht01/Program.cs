using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            Console.WriteLine("Elevator is in now in floor: " + elevator.Floor);
            bool result;
            do
            {
                Console.Write("Give a new floor number (1-5) > ");
                string str = Console.ReadLine();
                int num;
                result = int.TryParse(str, out num);
                elevator.Floor = num;
                Console.WriteLine("Elevator is now in floor: " + elevator.Floor);
            } while (result == true);
        }
    }
}
