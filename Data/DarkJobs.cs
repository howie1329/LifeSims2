using System;

namespace LifeSims2.Data
{
    public class DarkJobs
    {
        public string JobName { get; set; }
        public double Sal { get; set; }

        /// <summary>
        /// Creates a dark jobs array
        /// </summary>
        /// <returns> dark jobs array</returns>
        public DarkJobs[] CreateDarkJobsList()
        {
            DarkJobs[] DarkJobsList = new DarkJobs[4];
            DarkJobsList[0] = new DarkJobs();
            DarkJobsList[0].JobName = "Drug Dealer";
            DarkJobsList[0].Sal = 28000;
            DarkJobsList[1] = new DarkJobs();
            DarkJobsList[1].JobName = "Booster";
            DarkJobsList[1].Sal = 30250;
            DarkJobsList[2] = new DarkJobs();
            DarkJobsList[2].JobName = "Black Market Merchant";
            DarkJobsList[2].Sal = 40000;
            DarkJobsList[3] = new DarkJobs();
            DarkJobsList[3].JobName = "Middle Man";
            DarkJobsList[3].Sal = 24000;

            return DarkJobsList;
        }

        /// <summary>
        /// Displays dark jobs array
        /// </summary>
        /// <param name="DarkJobsList"></param>
        public void ShowDarkJobsList(DarkJobs[] DarkJobsList)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(DarkJobsList[i].JobName);
                Console.WriteLine("Cost:" + DarkJobsList[i].Sal);
                Console.WriteLine("----------------------");
            }
        }
    }
}