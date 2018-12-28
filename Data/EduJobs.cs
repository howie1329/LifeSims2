using System;

namespace LifeSims2.Data
{
    public class EduJobs
    {
        public string JobName { get; set; }
        public double Sal { get; set; }

        /// <summary>
        /// Creates a array of Edu Jobs
        /// </summary>
        /// <returns></returns>
        public EduJobs[] CreateEduJobList()
        {
            EduJobs[] EduJobList = new EduJobs[5];
            EduJobList[0] = new EduJobs();
            EduJobList[0].JobName = "DayCare Worker";
            EduJobList[0].Sal = 15000;
            EduJobList[1] = new EduJobs();
            EduJobList[1].JobName = "Teacher";
            EduJobList[1].Sal = 30000;
            EduJobList[2] = new EduJobs();
            EduJobList[2].JobName = "Professor";
            EduJobList[2].Sal = 50000;
            EduJobList[3] = new EduJobs();
            EduJobList[3].JobName = "Principal";
            EduJobList[3].Sal = 55000;
            EduJobList[4] = new EduJobs();
            EduJobList[4].JobName = "Special Ed. Worker";
            EduJobList[4].Sal = 25000;
            return EduJobList;
        }

        /// <summary>
        /// Displays the array of Edu Jobs
        /// </summary>
        /// <param name="EduJobList"></param>
        public void ShowEduList(EduJobs[] EduJobList)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(EduJobList[i].JobName);
                Console.WriteLine("Cost:" + EduJobList[i].Sal);
                Console.WriteLine("----------------------");
            }
        }
    }
}