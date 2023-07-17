using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal interface ICar
    {
        string Name { get; set; }

        List<IDamages> Damages { get; set; }
    }
}
