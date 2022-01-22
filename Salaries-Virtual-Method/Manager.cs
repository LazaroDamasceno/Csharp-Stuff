using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesVirtualMethod
{
    internal class Manager : Supervisor
    {
        public Manager(double monthSalary, double bonus)
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
