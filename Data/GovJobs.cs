using System;

namespace LifeSims2.Data
{
    public class GovJobs
    {

        public string JobName { get; set; }
        public double Sal { get; set; }

        /// <summary>
        /// Creates a array of Government Jobs
        /// </summary>
        /// <returns></returns>
        public GovJobs[] CreateGovJobs()
        {
            GovJobs[] GovJobsList = new GovJobs[5];
            GovJobsList[0] = new GovJobs();
            GovJobsList[0].JobName = "Receptionist";
            GovJobsList[0].Sal = 10000;
            GovJobsList[1] = new GovJobs();
            GovJobsList[1].JobName = "Police Officer";
            GovJobsList[1].Sal = 32000;
            GovJobsList[2] = new GovJobs();
            GovJobsList[2].JobName = "Social Worker";
            GovJobsList[2].Sal = 60000;
            GovJobsList[3] = new GovJobs();
            GovJobsList[3].JobName = "Government Lawyer";
            GovJobsList[3].Sal = 74000;
            GovJobsList[4] = new GovJobs();
            GovJobsList[4].JobName = "President";
            GovJobsList[4].Sal = 100000;

            return GovJobsList;
        }

        /// <summary>
        /// Shows the Government Jobs Array
        /// </summary>
        /// <param name="GovJobsList"></param>
        public void ShowGovJobs(GovJobs[] GovJobsList)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(GovJobsList[i].JobName);
                Console.WriteLine("Cost:" + GovJobsList[i].Sal);
                Console.WriteLine("----------------------");
            }
        }
    }
}