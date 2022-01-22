using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAbstractClass
{
    internal class Trapezium : Area
    {
        public Trapezium(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public override string DisplayArea()
        {
            return $"The trapezium's area is {((A + B) * (C * 1.0)) / 2.0} m2.";
        }
    }
}
