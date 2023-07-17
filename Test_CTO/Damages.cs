using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class Damages : IDamages
    {
        public string Type { get; set; }

        public decimal Price { get; set; }


        public string InputType()
        {
            Console.WriteLine("Enter type - ");
            this.Type = Console.ReadLine();
            return Type;
        }

        public void OutputType() 
        {
            Console.WriteLine($"Type - {this.Type}");
        }

        public decimal InputDecimal()
        {
            Console.WriteLine("Enter price - ");
            this.Price = Convert.ToDecimal( Console.ReadLine() );
            return Price;
        }

        public void OutputDecimal()
        {
            Console.WriteLine($"Price = {this.Price}");
        }
    }
}
