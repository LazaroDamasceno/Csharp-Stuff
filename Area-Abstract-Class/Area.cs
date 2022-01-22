using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAbstractClass
{
    internal abstract class Area
    {
        protected double A { get; set; }
        protected double B { get; set; }
        protected double C { get; set; }
        public abstract string DisplayArea();
    }
}
