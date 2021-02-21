using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Power : InputCompIF
    {
        public double compute(double input, double previous)
        {
            return Math.Pow(previous, input);
        }
    }
}
