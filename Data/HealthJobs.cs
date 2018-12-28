using System;

namespace LifeSims2.Data
{
    public class HealthJobs
    {
        public string JobName { get; set; }
        public double Sal { get; set; }

        /// <summary>
        /// Creates a array of Health related Jobs
        /// </summary>
        /// <returns></returns>
        public HealthJobs[] CreateHealthJobs()
        {
            HealthJobs[] HealthJobs = new HealthJobs[5];
            HealthJobs[0] = new HealthJobs();
            HealthJobs[0].JobName = "Nurse";
            HealthJobs[0].Sal = 25000;
            HealthJobs[1] = new HealthJobs();
            HealthJobs[1].JobName = "Physical Therapist";
            HealthJobs[1].Sal = 48500;
            HealthJobs[2] = new HealthJobs();
            HealthJobs[2].JobName = "Pediatrician";
            HealthJobs[2].Sal = 80000;
            HealthJobs[3] = new HealthJobs();
            HealthJobs[3].JobName = "Gynecologist";
            HealthJobs[3].Sal = 65000;
            HealthJobs[4] = new HealthJobs();
            HealthJobs[4].JobName = "Doctor";
            HealthJobs[4].Sal = 120000;

            return HealthJobs;
        }

        /// <summary>
        /// Shows the array of Health Jobs
        /// </summary>
        /// <param name="HealthJobs"></param>
        public void ShowHealthJobs(HealthJobs[] HealthJobs)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(HealthJobs[i].JobName);
                Console.WriteLine("Cost:" + HealthJobs[i].Sal);
                Console.WriteLine("----------------------");
            }
        }
    }
}