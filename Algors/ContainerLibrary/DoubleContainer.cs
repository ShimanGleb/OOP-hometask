using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerLibrary
{
    public class DoubleContainer: AbstractDoubleContainer
    {
        double value1 = 0.0;

        public DoubleContainer(int i)
        {
            value1 = i;
        }
        
        public override double ReturnValue(string name)
        {
            if (name == "value1")
            {
                return value1;
            }
            return 0.0;
        }

        public override int compareValues(AbstractDoubleContainer container, string name)
        {
            double comparingValue = 0.0;
            if (name == "value1")
            {
                comparingValue = value1;
            }
            return comparingValue.CompareTo(container.ReturnValue(name));
        }
    }
}
