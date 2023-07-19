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

        public void AddDamages()
        {
            DamagesList = new List<IDamages>();
            damages.InputType();
            Console.Clear();
            OutputCarBrand();
            OutputCarModel();
            damages.OutputType();
            damages.InputPriceDetails();
            damages.InputPriceWork();
            DamagesList.Add(damages);              
        }

        public void OutDamages()
        {
            damages.OutputType();
            damages.OutputPriceDetails();
            damages.OutputPriceWork();
        }
       
        public void ChangDamage()
        {
            foreach (var someDamage in DamagesList) 
            {
                bool a = true;
                while(a)
                {
                    Console.Clear();
                    OutDamages();
                    Console.WriteLine("1. Type\n2. Price details\n3. Price work\n4. exit");
                    byte.TryParse(Console.ReadLine(), out var someByte);
                    if (someByte == 1)
                    {
                        Console.Clear();
                        OutDamages();
                        damages.InputType();
                    }
                    else if (someByte == 2)
                    {
                        Console.Clear();
                        OutDamages();
                        damages.InputPriceDetails();
                    }
                    else if (someByte == 3)
                    {
                        Console.Clear();
                        OutDamages();
                        damages.InputPriceWork();
                    }
                    else if(someByte == 4)
                    {
                        a = false;                        
                    }
                    else
                    {
                        Console.WriteLine("Not a some type");
                    }
                }
                if (a == false)
                    break;
            }
        }

        public IEnumerator GetEnumerator()
        {
            yield return this;
        }
    }
}
