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
            this.PriceWork = InputDecimal();
            return PriceWork;
        }

        public void OutputPriceWork()
        {
            Console.WriteLine($"Price work = {this.PriceWork}");
        }

        public decimal InputPriceDetails()
        {
            this.PriceDetails = InputDecimal();
            return PriceDetails;
        }

        public void OutputPriceDetails()
        {
            Console.WriteLine($"Price details = {this.PriceDetails}");
        }

        public decimal InputDecimal()
        {            
            Console.Write("Enter price - ");
            bool parseOK = decimal.TryParse(Console.ReadLine(), out var type);
            if (parseOK == true || type >= 0)
            {
                Console.WriteLine("OK");
                this.PriceWork = type;
                return PriceWork;
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
