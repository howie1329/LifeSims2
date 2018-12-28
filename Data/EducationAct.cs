using System;

namespace LifeSims2.Data
{
    public class EducationAct
    { 
        public string ActivitiesName { get; set; }
        public int EducationBenefits { get; set; }
        public int HappinessBenefits { get; set; }
        public double Cost { get; set; }

        /// <summary>
        /// Creates a List of Edu Acts 
        /// </summary>
        /// <returns></returns>
        public EducationAct[] CreateEduList()
        {
            EducationAct[] EduList = new EducationAct[6];
            EduList[0] = new EducationAct();
            EduList[0].ActivitiesName = "Study At The Library";
            EduList[0].EducationBenefits = 5;
            EduList[0].HappinessBenefits = -5;
            EduList[0].Cost = 0;
            EduList[1] = new EducationAct();
            EduList[1].ActivitiesName = "Take a course";
            EduList[1].EducationBenefits = 10;
            EduList[1].HappinessBenefits = -8;
            EduList[1].Cost = 150;
            EduList[2] = new EducationAct();
            EduList[2].ActivitiesName = "Community College";
            EduList[2].EducationBenefits = 0;
            EduList[2].HappinessBenefits = 0;
            EduList[2].Cost = 0;
            EduList[3] = new EducationAct();
            EduList[3].ActivitiesName = "Education University";
            EduList[3].EducationBenefits = 0;
            EduList[3].HappinessBenefits = 0;
            EduList[3].Cost = 45000;
            EduList[4] = new EducationAct();
            EduList[4].ActivitiesName = "Health University";
            EduList[4].EducationBenefits = 0;
            EduList[4].HappinessBenefits = 0;
            EduList[4].Cost = 60000;
            EduList[5] = new EducationAct();
            EduList[5].ActivitiesName = "Government University";
            EduList[5].EducationBenefits = 0;
            EduList[5].HappinessBenefits = 0;
            EduList[5].Cost = 62000;
            return EduList;
        }

        /// <summary>
        /// Shows the Edu Acts
        /// </summary>
        /// <param name="EduList"></param>
        public void ShowList(EducationAct[] EduList)
        {
            for (var i = 0; i < 5; i++)
            {

                Console.WriteLine(EduList[i].ActivitiesName);
                Console.WriteLine("Cost:" + EduList[i].Cost);
                Console.WriteLine("----------------------");
            }
        }

       
    }
}