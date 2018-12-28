using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSims2.Data
{
    class HealthAct
    {
        public string ActivitiesName;
        public int HealthBenefits;
        public double Cost;

        /// <summary>
        /// Creates an array of Health Acts
        /// </summary>
        /// <returns></returns>
        public HealthAct[] CreateHealthList()
        {
            var HealthList = new HealthAct[3];
            HealthList[0] = new HealthAct();
            HealthList[0].ActivitiesName = "Dr.Sam";
            HealthList[0].HealthBenefits = 10;
            HealthList[0].Cost = 75;
            HealthList[1] = new HealthAct();
            HealthList[1].ActivitiesName = "Dr.Mike";
            HealthList[1].HealthBenefits = 7;
            HealthList[1].Cost = 80;
            HealthList[2] = new HealthAct();
            HealthList[2].ActivitiesName = "Hospital";
            HealthList[2].HealthBenefits = 15;
            HealthList[2].Cost = 200;
            return HealthList;
        }

        /// <summary>
        /// Prints Health Acts
        /// </summary>
        /// <param name="HealthList"></param>
        public void PrintHealthAct(HealthAct[] HealthList)
        {
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(HealthList[i].ActivitiesName);
                Console.WriteLine("Cost:" + HealthList[i].Cost);
                Console.WriteLine("----------------------");
            }
        }

    }
}
