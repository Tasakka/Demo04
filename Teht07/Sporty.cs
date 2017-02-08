using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Sporty : Person
    {
        public string Sport { get; set; }
        public double Amount { get; set; }

        public Sporty()
        {

        }
        public Sporty(string name, string sex, int age, string sport, double amount)
            :base(name, sex, age)
        {
            Sport = sport;
            Amount = amount;
        }

        public override string ToString()
        {
            return base.ToString() + ", Sport: " + Sport + ", Amount: " + Age + " hours";
        }
    }
}
