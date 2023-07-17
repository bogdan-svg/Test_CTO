using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Truck truck = new Truck();
            truck.InputName();
            truck.AddDamages();                                               
            foreach(var car in truck)
            {
                car.OutputName();
            }
        }
    }
}
