using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class Input : DataBase
    {        
        public void InputTruck() 
        {
            Truck truck = new Truck();
            //truck.inputcarbrand();
            //truck.inputcarmodel();
            //truck.adddamages();
            trucks.Add(truck);
        }

        
    }
}
