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
            List<Truck> trucks = new List<Truck>();
            var truck = new Truck();
            truck.InputName();
            truck.AddDamages();            
            trucks.Add(truck); 
            
            foreach(var car in truck)
            {
                Console.WriteLine(truck);
                
                Console.ReadKey();
                //car.
                //car.OutputName();
                //car.OutputDamages();
                //Console.WriteLine($"Hohohoho {Convert.ToString(trucks[0])}");
            }
        }
    }
}
