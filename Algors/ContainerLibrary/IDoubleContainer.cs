using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerLibrary
{
    interface IDoubleContainer
    {
        double ReturnValue(string name);

        int compareValues(AbstractDoubleContainer container, string name);
    }
}
