using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class Truck : ICar
    {
        public string CarBrand { get; set; }

        public string CarModel { get; set; }        

        public List<IDamages> DamagesList { get; set; }

        Damages damages = new Damages();

        public IEnumerator GetEnumerator()
        {
            yield return this;
        }

        public string InputCarBrand()
        {
            Console.Write("Enter Car Brand");
            this.CarBrand = Console.ReadLine();
            return CarBrand;
        }

        public void OutputCarBrand()
        {
            Console.WriteLine($"Car brand - {this.CarBrand}");
        }
        
        public string InputCarModel()
        {
            Console.Write("Enter Car Model");
            this.CarBrand = Console.ReadLine();
            return CarModel;
        }

        public void OutputCarModel()
        {
            Console.WriteLine($"Car brand - {this.CarModel}");
        }

        public void AddDamages()
        {            
            DamagesList = new List<IDamages>();            
            damages.InputType();
            damages.InputDecimal();                      
            DamagesList.Add(damages);            
        }

        public void OutDamages()
        {
            damages.OutputType();
            damages.OutputDecimal();            
        }

        

    }
}
