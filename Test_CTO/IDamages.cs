using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    enum _Type { crash = 1, scratch , broken };
    internal interface IDamages
    {
        string TypeDamage { get; }

        decimal PriceWork { get; }

        decimal PriceDetails { get; }
    }
}
