using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Subtract : InputCompIF
    {
        public double compute(double input, double previous)
        {
            return previous - input;
        }
    }
}
