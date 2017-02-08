using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Bike : Vehicle
    {
        public bool GearWheel { get; set; }
        public string GearName { get; set; }

        public Bike()
        {

        }

        public Bike(string name, string model, int yearmodel, string color, bool gearwheel, string gearname)
            :base(name, model, yearmodel, color)
        {
            GearWheel = gearwheel;
            GearName = gearname;
        }

        public override string ToString()
        {
            return base.ToString() + ", Gear wheel: " + GearWheel + ", Gear name: " + GearName;
        }
    }
}
