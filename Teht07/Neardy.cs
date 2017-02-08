using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Neardy : Person
    {
        public string Game { get; set; }
        public double Amount { get; set; }

        public Neardy()
        {

        }
        public Neardy(string name, string sex, int age, string game, double amount)
            :base(name, sex, age)
        {
            Game = game;
            Amount = amount;
        }

        public override string ToString()
        {
            return base.ToString() + ", Game: " + Game + ", Amount: " + Amount + " hours";
        }
    }
}
