﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal interface IDamages
    {
        string Type { get; set; }

        decimal Price { get; set; }
    }
}