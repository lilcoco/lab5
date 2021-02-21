using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Log : NoInputCompIF
    {
        public double compute(double previous)
        {
            return Math.Log(previous);
        }
    }
}
