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
            Input input = new Input(); ;
            DataBase dataBase = new DataBase();
            Output output = new Output();
            ChangingValue changingValue = new ChangingValue();
            bool a = true;
            while (a)
            {
                Console.Clear();
                Console.WriteLine("Enter :\n1. input\n2. output\n3. Changing truck");
                decimal.TryParse(Console.ReadLine(), out var decimalValue);
                switch (decimalValue)
                {
                    case 1:                        
                        input.InputTruck();
                        break;
                    case 2:
                        output.OutputTrucks();                        
                        break;
                    case 3:
                        changingValue.ChangingTruck();
                        break;                    
                    case 4:
                        a = false;
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }                        
        }
    }
}
