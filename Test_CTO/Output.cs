using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CTO
{
    internal class Output : DataBase
    {
        public void OutputTrucks()
        {
            DataBase dataBase = new DataBase();
            for (int i = 0; i < trucks.Count; i++)
            {
                Console.Clear();
                dataBase[i].OutputCarBrand();
                dataBase[i].OutputCarModel();
                dataBase[i].OutDamages();
            }

        }
    }
}
