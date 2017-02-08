using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Veikko Pata", "Director", 3000);
            Console.WriteLine("Employee: " + employee.ToString());
            Boss boss = new Boss("Martti Mahtimies", "CEO", 60000, "Bugatti");
            Console.WriteLine("Boss: " + boss.ToString());
        }
    }
}
