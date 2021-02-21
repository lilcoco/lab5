using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    interface InputCompIF : CompIF
    {

        public double compute(double input, double previous);
    }
}
