using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class Truck : ICar
    {
        public string Name { get; set; }

        public List<IDamages> Damages { get; set; }

        private Damages damages = new Damages();

        private int DamageIndex = 0; 

        public IDamages this[int index]
        {
            get
            {
                DamageIndex = index;
                return Damages[index];
            }// => Damages[index];  
            set => Damages[index] = value;
        }

        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }

        public string InputName()
        {
            Console.WriteLine("Enter name");
            this.Name = Console.ReadLine();
            return Name;
        }
        public void OutputName()
        {
            Console.WriteLine($"Car name - {this.Name}");
        }
        
        public void AddDamages()
        {
            Damages = new List<IDamages>();
            var someTruck = new Damages();
            someTruck.InputType();
            someTruck.InputDecimal();
            Console.WriteLine(DamageIndex);
            Console.WriteLine(Damages.IndexOf(someTruck));
            Console.ReadKey();
            Damages.Add(someTruck);            
        }

        public void OutputDamages()
        {
            foreach ( var damage in Damages )
            {
                
                
                Console.Clear();
                Console.WriteLine($"number = {DamageIndex}");
                Console.WriteLine($"Price is = {damage.Price}");
                Console.WriteLine($"Type is = {damage.Type}");

            }
            
        }

    }
}
