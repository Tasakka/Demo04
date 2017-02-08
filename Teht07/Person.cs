using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Person
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public Person(string name, string sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Sex: " + Sex + ", Age: " + Age;
        }
    }
}
