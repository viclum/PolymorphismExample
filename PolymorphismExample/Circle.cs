using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
