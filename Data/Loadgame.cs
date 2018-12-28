using System;
using System.IO;
using LifeSims2.Game;

namespace LifeSims2.Data
{
    public class Loadgame
    {
        /// <summary>
        /// Converts SaveData back into readable data for the game
        /// </summary>
        public void Load() 
        {
            Console.WriteLine("Whats the name of the file?");
            var FileName = Console.ReadLine();
            string[] load = File.ReadAllLines(@"C:\Users\howar\CodeProjects\LifesimSaveData\" + FileName + ".txt");
            var UserInfo = new UserInfo();
            UserInfo.FirstName = load[0];
            UserInfo.LastName = load[1];
            UserInfo.City = load[2];
            UserInfo.Country = load[3];
            UserInfo.AgeStatus = load[4];
            UserInfo.Occupation = load[5];
            UserInfo.CurrentSchool = load[6];
            UserInfo.Happiness = Convert.ToInt32(load[7]);
            UserInfo.Health = Convert.ToInt32(load[8]);
            UserInfo.Education = Convert.ToInt32(load[9]);
            UserInfo.Looks = Convert.ToInt32(load[10]);
            UserInfo.Age = Convert.ToInt32(load[11]);
            UserInfo.Turns = Convert.ToInt32(load[12]);
            UserInfo.CommunityCollegeTime = Convert.ToInt32(load[13]);
            UserInfo.HealthUniversityTime = Convert.ToInt32(load[14]);
            UserInfo.EducationUniversityTime = Convert.ToInt32(load[15]);
            UserInfo.GovernmentUniversityTime = Convert.ToInt32(load[16]);
            UserInfo.Money = Convert.ToDouble(load[17]);
            UserInfo.GainMoney = Convert.ToDouble(load[18]);
            UserInfo.Sal = Convert.ToDouble(load[19]);
            UserInfo.HighSchoolD = Convert.ToBoolean(load[20]);
            UserInfo.CommunityCollegeD = Convert.ToBoolean(load[21]);
            UserInfo.EducationUniversityD = Convert.ToBoolean(load[22]);
            UserInfo.HealthUniversityD = Convert.ToBoolean(load[23]);
            UserInfo.GovernmentUniversityD = Convert.ToBoolean(load[24]);
            UserInfo.AttendHighSchool = Convert.ToBoolean(load[25]);
            UserInfo.AttendCommunityCollege = Convert.ToBoolean(load[26]);
            UserInfo.AttendEducationUniversity = Convert.ToBoolean(load[27]);
            UserInfo.AttendHealthUniversity = Convert.ToBoolean(load[28]);
            UserInfo.AttendGovernmentUniversity = Convert.ToBoolean(load[29]);
            UserInfo.DiseaseName = load[30];
            UserInfo.CurrentState = load[31];
            UserInfo.DiseaseEffect = Convert.ToInt32(load[32]);

            var Game = new MainGame(UserInfo);
            Game.MainGameLoop();
        }
    }
}