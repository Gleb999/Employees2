using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            Salesperson fran = new Salesperson("Fran", 43, 94, 3000, "932-32-3232", 9000);
            chucky.GiveBonus(200);
            chucky.DisplayStats();
            Console.ReadLine();
        }
    }
}
