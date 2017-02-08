using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int SeatCount { get; set; }

        public Boat()
        {

        }

        public Boat(string name, string model, int yearmodel, string color, string boattype, int seatcount)
            :base(name, model, yearmodel, color)
        {
            BoatType = boattype;
            SeatCount = seatcount;
        }

        public override string ToString()
        {
            return base.ToString() + ", Boat type: " + BoatType + ", Seat count: " + SeatCount;
        }
    }
}
