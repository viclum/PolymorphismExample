﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{

    abstract class Shape
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public abstract double FindArea();

    }
}
