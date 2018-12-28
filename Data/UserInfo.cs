using System;
using System.IO;

namespace LifeSims2.Data
{
    public class UserInfo
    {
        private static readonly Random rnd = new Random();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Age { get; set; } = 0;
        public string AgeStatus { get; set; } = "Baby";
        public int Happiness { get; set; } = rnd.Next(101);
        public int Health { get; set; } = rnd.Next(1, 101);
        public int Education { get; set; } = rnd.Next(101);
        public int Looks { get; set; } = rnd.Next(101);
        public double Money { get; set; } = 0.00;
        public bool Status { get; private set; } = true;
        public int Turns { get; set; } = 3;
        public bool JobStatus { get; set; } = false;
        public string Occupation { get; set; } = "None";
        public string CurrentSchool { get; set; } = "None";
        public bool HighSchoolD { get; set; } = false;
        public bool AttendHighSchool { get; set; } = false;
        public bool CommunityCollegeD { get; set; } = false;
        public int CommunityCollegeTime { get; set; }
        public bool AttendCommunityCollege { get; set; } = false;
        public bool EducationUniversityD { get; set; } = false;
        public int EducationUniversityTime { get; set; }
        public bool AttendEducationUniversity { get; set; } = false;
        public bool HealthUniversityD { get; set; } = false;
        public int HealthUniversityTime { get; set; }
        public bool AttendHealthUniversity { get; set; } = false;
        public bool GovernmentUniversityD { get; set; } = false;
        public int GovernmentUniversityTime { get; set; }
        public bool AttendGovernmentUniversity { get; set; } = false;
        public double GainMoney { get; set; }
        public double Sal { get; set; }
        public string DiseaseName { get; set; } = "None";
        public int DiseaseEffect { get; set; }
        public string CurrentState { get; set; } = "Healthy";

        /// <summary>
        /// Checks if Health Reaches 0
        /// </summary>
        public void HealthCheck() // Checks if health is above zero 
        {
            if (Health == 0) Status = false;
        }
    }
}