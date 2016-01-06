using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerLibrary
{
    public abstract class AbstractStringContainer: IStringContainer
    {
        public abstract string ReturnValue(string name);

        public abstract int compareValues(AbstractStringContainer container, string name);
    }
}
