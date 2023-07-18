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
                Console.WriteLine($"index {i} if next press");
                byte.TryParse(Console.ReadLine(), out var someByte);

                if (i == someByte)
                {
                    dataBase[i].TestChangDamage();
                    dataBase[i].OutDamages();
                    //truck[someByte]
                    //Test(someByte);
                    //dataBase[i].OutDamages();
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
