﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class DataBase
    {
        protected List<Truck> trucks = new List<Truck>();

        protected void AddTrucks(Truck truck)
        {            
            trucks.Add(truck);
        }

        public void OutputTruck()
        {
            foreach (var item in trucks)
            {
                item.OutputCarBrand();
                //item.OutputCarModel();
                //item.OutDamages();
                Console.ReadKey();
            }

        }

        protected Truck this[int index]
        {
            get => trucks[index];
            set => trucks[index] = value;
        }
    }
}
