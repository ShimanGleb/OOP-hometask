using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerLibrary
{
    public abstract class AbstractDoubleContainer:IDoubleContainer
    {
        public abstract double ReturnValue(string name);

        public abstract int compareValues(AbstractDoubleContainer container, string name);
    }
}
