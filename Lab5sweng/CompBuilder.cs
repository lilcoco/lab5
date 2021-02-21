using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class CompBuilder
    {
        private double currentValue;
        private double input;
        private CompIF comp;
        private Factory factory;
      
        public CompBuilder(double previousValue, double input, String str)
        {
            this.currentValue = previousValue;
            this.input = input;
            this.factory = new Factory();
           
            this.comp = factory.createComp(str);
            
        }

        public double execute()
        {
            if (comp.GetType() == Type.GetType("Lab5.Log"))
            {

                currentValue = ((NoInputCompIF)comp).compute(currentValue);

            }
            else if (comp.GetType() == Type.GetType("Lab5.Initialize"))
            {

                currentValue = ((NoInputCompIF)comp).compute(input);
            }
            else
            {
                currentValue = ((InputCompIF)comp).compute(input, currentValue);
            }

            
            return currentValue;
        }

        public double getCurrValue()
        {
            return this.currentValue;
        }
    }
}
