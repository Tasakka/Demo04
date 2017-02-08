using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int YearModel { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string name, string model, int yearmodel, string color)
        {
            Name = name;
            Model = model;
            YearModel = yearmodel;
            Color = color;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Year model: " + YearModel + ", Color: " + Color;
        }
    }
}
