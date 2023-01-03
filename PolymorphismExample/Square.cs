using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Square : Shape
    {
        public double Length { get; set; }
        public override double FindArea()
        {
            return Math.Pow(Length, 2);
        }
    }
}
