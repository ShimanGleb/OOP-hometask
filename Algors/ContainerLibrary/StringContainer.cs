using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerLibrary
{
    public class StringContainer: IStringContainer
    {
        string value1 = "";

        public StringContainer(int i)
        {
            value1 = i.ToString();
        }

        public string ReturnValue(string name)
        {
            if (name == "value1")
            {
                return value1;
            }
            return "";
        }

        public int compareValues(StringContainer container, string name)
        {
            string comparingValue="";
            if (name == "value1")
            {
                comparingValue = value1;
            }
            return comparingValue.CompareTo(container.ReturnValue(name));
        }
    }
}
