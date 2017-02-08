using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();
            Console.WriteLine("The starting volume is " + amp.Volume);
            bool result;
            do
            {
                Console.Write("Give a new volume > ");
                string str = Console.ReadLine();
                int num;
                result = int.TryParse(str, out num);
                amp.Volume = num;
                Console.WriteLine("The volume is: " + amp.Volume);
            } while (result == true);
        }
    }
}
