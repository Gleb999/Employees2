﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        public Manager (string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
        : base(fullName, age, empID, currPay, ssn){
            StockOptions = numbOfOpts;
        }
        public int StockOptions { get; set; }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(float amount)
            {
                base.GiveBonus(amount);
                Random r = new Random();
                StockOptions += r.Next(500);
            }
        }
    }
}
