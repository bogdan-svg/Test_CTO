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
        Damages damages = new Damages();

        public string CarBrand { get; private set; }

        public string CarModel { get; private set; }        

        public List<IDamages> DamagesList { get; private set; }

        public Truck()
        {
            this.CarBrand = InputCarBrand();
            this.CarModel = InputCarModel();
            DamagesList = new List<IDamages>()
            {
                AddDamages()
            };            
        }

        public IDamages this[int index]
        {
            get => DamagesList[index];
            set => DamagesList[index] = value;
        }
        
       

        public string InputCarBrand()
        {
            Console.Write("Enter Car Brand - ");
            this.CarBrand = Console.ReadLine();
            return CarBrand;
        }

        public void OutputCarBrand()
        {
            Console.WriteLine($"Car brand - {this.CarBrand}");            
        }

        public string InputCarModel()
        {
            Console.Write("Enter Car Model - ");
            this.CarModel = Console.ReadLine();
            return CarModel;
        }

        public void OutputCarModel()
        {
            Console.WriteLine($"Car model - {this.CarModel}");
        }

        public Damages AddDamages()
        {                                 
            damages.InputType();
            damages.InputPriceDetails();
            damages.InputPriceWork();
            return damages;            
        }

        public void OutDamages()
        {
            damages.OutputType();
            damages.OutputPriceDetails();
            damages.OutputPriceWork();
            Console.WriteLine("ReadKey");
            Console.ReadKey();
        }
       
        public IEnumerator GetEnumerator()
        {
            yield return this;
        }
    }
}
