using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class DataBase
    {
        protected static List<Truck> trucks = new List<Truck>();

        public Truck this[int index]
        {
            get => trucks[index];
            set => trucks[index] = value;
        }




        //protected void AddTrucks(Truck truck)
        //{            
        //    trucks.Add(truck);
        //}        




    }
}
