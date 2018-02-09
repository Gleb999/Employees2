using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesPerson : Salesperson
    {
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numOfSales)
            : base ( fullName, age, empID, currPay, ssn, numOfSales){ }
        public override void GiveBonus(float amount)
        {

        }

    }
}
