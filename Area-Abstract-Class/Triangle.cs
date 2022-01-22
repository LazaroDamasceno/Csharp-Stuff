using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAbstractClass
{
    internal class Triangle : Area
    {
        public Triangle(double A, double B)
        {
            this.A = A;
            this.B = B;
        }
        public override string DisplayArea()
        {
            return $"The triangle's area is {(A * B) / 2.0} m2.";
        }
    }
}
