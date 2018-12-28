using System;
using System.Collections.Generic;
using LifeSims2.Data;

namespace LifeSims2.Game
{
    public class MainJobMenu
    {
        /// <summary>
        /// Main Menu for job selection
        /// </summary>
        public void MJobMenu()
        {
            Console.Clear();
            const string menuitem = "================Job Menu================";
            const string menuitem1 = "E.) Education";
            const string menuitem2 = "G.) Government";
            const string menuitem3 = "H.) Health";
            const string menuitem4 = "L.) Low-End";
            const string menuitem5 = "B.) Back Alley";
            const string menuitem6 = "Q.) Exit";

            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem3.Length / 2) + "}", menuitem3);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem4.Length / 2) + "}", menuitem4);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem5.Length / 2) + "}", menuitem5);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem6.Length / 2) + "}", menuitem6);
            Console.WriteLine("Select what are you going to do");
            JobList();
        }

        /// <summary>
        /// to see the list of jobs
        /// </summary>
        private void JobList() 
        {
            var EduMainJobs = new EduJobs();
            var EduJobs = EduMainJobs.CreateEduJobList();
            var JobListInput = Console.ReadLine();
            var GovMainJobs = new GovJobs();
            var GovJobs = GovMainJobs.CreateGovJobs();
            var HealthMainJobs = new HealthJobs();
            var HealthJobs = HealthMainJobs.CreateHealthJobs();
            var LowEndMainJobs = new LowEndJobs();
            var LowEndJobs = LowEndMainJobs.CreateLowEndJobs();
            var DarkMainJobs = new DarkJobs();
            var DarkJobs = DarkMainJobs.CreateDarkJobsList();
            switch (JobListInput.ToLower())
            {
                case "e":
                   EduMainJobs.ShowEduList(EduJobs);
                    break;
                case "g":
                    GovMainJobs.ShowGovJobs(GovJobs);
                    break;
                case "h":
                    HealthMainJobs.ShowHealthJobs(HealthJobs);
                    break;
                case "l":
                    LowEndMainJobs.ShowLowEndJobsList(LowEndJobs);
                    break;
                case "b":
                    DarkMainJobs.ShowDarkJobsList(DarkJobs);
                    break;
                case "q":
                    break;
                default:
                    if (string.IsNullOrWhiteSpace(JobListInput))
                    {
                        MJobMenu();
                    }
                    break;
            }
        }
    }
}