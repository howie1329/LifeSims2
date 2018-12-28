using System;

namespace LifeSims2.Data
{
    public class LowEndJobs
    {
        public string JobName { get; set; }
        public double Sal { get; set; }

        /// <summary>
        /// Creates a array of Low End Jobs
        /// </summary>
        /// <returns></returns>
        public LowEndJobs[] CreateLowEndJobs()
        {
            LowEndJobs[] LowEndJobsList = new LowEndJobs[5];
            LowEndJobsList[0] = new LowEndJobs();
            LowEndJobsList[0].JobName = "Waiter";
            LowEndJobsList[0].Sal = 75000;
            LowEndJobsList[1] = new LowEndJobs();
            LowEndJobsList[1].JobName = "Cashier";
            LowEndJobsList[1].Sal = 15250;
            LowEndJobsList[2] = new LowEndJobs();
            LowEndJobsList[2].JobName = "Garbage Man";
            LowEndJobsList[2].Sal = 18000;
            LowEndJobsList[3] = new LowEndJobs();
            LowEndJobsList[3].JobName = "Maid";
            LowEndJobsList[3].Sal = 22000;
            LowEndJobsList[4] = new LowEndJobs();
            LowEndJobsList[4].JobName = "Nanny";
            LowEndJobsList[4].Sal = 25000;
            return LowEndJobsList;
        }

        /// <summary>
        /// Shows the array of Low End Jobs
        /// </summary>
        /// <param name="LowEndJobsList"></param>
        public void ShowLowEndJobsList(LowEndJobs[] LowEndJobsList)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(LowEndJobsList[i].JobName);
                Console.WriteLine("Cost:" + LowEndJobsList[i].Sal);
                Console.WriteLine("----------------------");
            }
        }
    }
}