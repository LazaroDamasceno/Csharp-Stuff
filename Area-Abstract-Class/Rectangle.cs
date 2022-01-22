using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAbstractClass
{
    internal class Rectangle : Area
    {
        public Rectangle(double A, double B)
        {
            this.A = A;
            this.B = B;
        }
        public override string DisplayArea()
        {
            return $"The rectangle's are is {A * B} m2.";
        }
    }
}
