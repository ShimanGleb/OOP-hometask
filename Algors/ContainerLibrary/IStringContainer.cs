﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerLibrary
{
    interface IStringContainer
    {
        string ReturnValue(string name);

        int compareValues(StringContainer container, string name);
    }
}
