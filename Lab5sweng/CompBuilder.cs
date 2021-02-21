using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class CompBuilder
    {
        private double previousValue;
        private double input;
        private CompIF comp;
        private Factory factory;
        private double result = 0.0;


        public CompBuilder()
        {
            this.previousValue = 0.0;
        }
        public CompBuilder(double previousValue, double input, String str)
        {
            this.previousValue = previousValue;
            this.input = input;
            this.factory = new Factory();
           
            this.comp = factory.createComp(str);
            
        }

        public double execute()
        {
            if (comp.GetType() == Type.GetType("Lab5.Log"))
            {

                result = ((NoInputCompIF)comp).compute(previousValue);

            }
            else if (comp.GetType() == Type.GetType("Lab5.Initialize"))
            {

                result = ((NoInputCompIF)comp).compute(input);
            }
            else
            {
                result = ((InputCompIF)comp).compute(input, previousValue);
            }

            this.previousValue = result;
            return result;
        }

        public double getCurrValue()
        {
            return this.previousValue;
        }
    }
}
