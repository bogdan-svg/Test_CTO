using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal interface ICar
    {
        string CarModel { get; }

        string CarBrand { get; set; }

        List<IDamages> DamagesList { get; set; }        
    }
}
