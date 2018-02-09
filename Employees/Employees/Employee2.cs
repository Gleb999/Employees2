using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee2
    {
        protected string empName;
        protected int empID;
        protected float currPay;
        protected string value;
        protected int empAge;
        protected string empSSN;

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standart, Gold, Platinum
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        protected BenefitPackage empBenefist = new BenefitPackage();

        public double GetBenefitCost()
        { rerurn empBenefist.ComputePayDeduction(); }

        public BenefistPackage Benefists
        {
            get { return empBenefist; }
            set { empBenefist = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public string Name()
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name must be less than 16 Characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public string GetName()
        {
            return empName;
        }

        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name must be less than 16 characters!");
                else{
                    empName = name;
                }
            }
        }
    }
}
