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
            Input input;
            DataBase dataBase = new DataBase();
            bool a = true;
            while (a)
            {
                Console.WriteLine("Enter :\n1. input\n2. output");
                decimal.TryParse(Console.ReadLine(), out var decimalValue);
                switch (decimalValue)
                {
                    case 1:
                        input = new Input();
                        input.InputTruck();
                        break;
                    case 2:
                        dataBase.OutputTruck();
                        //input = new Input();
                        //input.OutputTruck();
                        break;
                    case 3:
                        a = false;
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
            
            //foreach(var car in truck)
            //{
            //    car.OutputName();
            //}
        }
    }
}
