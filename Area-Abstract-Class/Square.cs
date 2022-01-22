using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAbstractClass
{
    internal class Square : Area
    {
        double a;
        public Square(double A)
        {
            this.A = A;
        }
        public override string DisplayArea()
        {
            return $"The square's area is {Math.Pow(A, 2)} m2.";
        }
    }
}
