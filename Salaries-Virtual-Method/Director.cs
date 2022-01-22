
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesVirtualMethod
{
    internal class Director : Manager
    {
        public Director(double monthSalary, double bonus)
            : base(monthSalary, bonus)
        {
            this.monthSalary = monthSalary;
            this.bonus = bonus;
        }
        public override double DisplaySalary()
        {
            monthSalary += monthSalary * bonus;
            return monthSalary;
        }
    }
}
