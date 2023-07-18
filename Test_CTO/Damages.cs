using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class Damages : IDamages
    {
        public string TypeDamage { get; private set; }

        public decimal PriceWork { get; private set; }

        public decimal PriceDetails { get; private set; }
        
        public string InputType()
        {
            var count = 1;
            Console.Write("Enter type: \n");
            foreach (var item in Enum.GetValues(typeof(_Type)))
            {                
                Console.WriteLine($"{count} - {item.ToString()}");
                count++;
            }
            while(true)
            {
                bool parseOK = byte.TryParse(Console.ReadLine(), out var type);
                if (type > 0 || type < Enum.GetValues(typeof(_Type)).Length || parseOK == true)
                {
                    this.TypeDamage = Convert.ToString((_Type)type);
                    return this.TypeDamage;
                }
                else
                {
                    return "test esle !(";
                }
            }            
        }

        public void OutputType() 
        {
            Console.WriteLine($"Type - {this.TypeDamage}");
        }

        public decimal InputPriceWork()
        {
            Console.Write("Enter Price Work - ");
            this.PriceWork = InputDecimal();
            return PriceWork;
        }

        public void OutputPriceWork()
        {
            Console.WriteLine($"Price work = {this.PriceWork}");
        }

        public decimal InputPriceDetails()
        {
            Console.Write("Enter Price Details - ");
            this.PriceDetails = InputDecimal();
            return PriceDetails;
        }

        public void OutputPriceDetails()
        {
            Console.WriteLine($"Price details = {this.PriceDetails}");
        }

        public decimal InputDecimal()
        {                        
            bool parseOK = decimal.TryParse(Console.ReadLine(), out var type);
            if (parseOK == true || type >= 0)
            {                
                return type;
            }
            else
            {
                return 0;
            }

        }

        public IEnumerator GetEnumerator()
        {
            yield return this;
        }
    }
}
