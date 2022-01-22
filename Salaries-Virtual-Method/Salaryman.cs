using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesVirtualMethod
{
    internal class Salaryman
    {
        public Salaryman(double monthSalary)
        {
            this.monthSalary = monthSalary;
        }
        protected double monthSalary { get; set; }
        public virtual double DisplaySalary() 
        { 
            return monthSalary;
        }
    }
}
