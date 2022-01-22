using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesVirtualMethod
{
    internal class Supervisor : Salaryman
    {
        public Supervisor(double monthSalary, double bonus)
            : base(monthSalary)
        {
            this.monthSalary = monthSalary;
            this.bonus = bonus;
        }
        protected double bonus;
        public override double DisplaySalary()
        {
            monthSalary += monthSalary * bonus;
            return monthSalary;
        }
    }
}
