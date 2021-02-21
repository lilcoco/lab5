using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Product : InputCompIF
    {
        public double compute(double input, double previous)
        {
            return input*previous;
        }
    }
}
