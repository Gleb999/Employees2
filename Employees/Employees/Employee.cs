using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        
        public Employee() { }
        public Employee(string name, int id, float pay)
            :this( name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
            empSSN = ssn;
        }
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", numberOfOptions)

        }
    }
}
