using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class Input
    {
        List<Truck> trucks = new List<Truck>();

        public void InputTruck() 
        {
            Truck truck = new Truck();
            truck.InputCarBrand();
            truck.InputCarModel();
            truck.AddDamages();
            trucks.Add(truck);
        }

        public void Output()
        {

        }
    }
}
