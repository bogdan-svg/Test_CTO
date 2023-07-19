using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class ChangingValue : DataBase
    {
        internal void ChangingTruck()
        {
            DataBase dataBase = new DataBase();
            Truck truck = new Truck();
            for (int i = 0; i < trucks.Count; i++)
            {
                Console.Clear();
                dataBase[i].OutputCarBrand();
                dataBase[i].OutputCarModel();
                dataBase[i].OutDamages();
                if (trucks.Count - i != 1)
                    Console.WriteLine($"\nPress space bar if want chang\nPress enter to next");
                else
                    Console.WriteLine($"\nPress space bar if want chang\nThis last press enter to exit");
                var a = Console.ReadKey().Key;
                if (a == ConsoleKey.Spacebar)
                {
                    dataBase[i].ChangDamage();
                    dataBase[i].OutDamages();                    
                }
                else
                    continue;                
            }
        }
        protected void Test(byte index)
        {
            DataBase dataBase = new DataBase();
            dataBase[index].OutputCarModel();
        }
    }
}
