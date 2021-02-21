using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Factory : FactoryIF
    {
        public CompIF createComp(String value)
        {
            Type t = Type.GetType("Lab5." + value);
            return (CompIF)Activator.CreateInstance(t);
        } 
       
    }
}
