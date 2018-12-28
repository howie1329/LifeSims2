using System;
using LifeSims2.Data;

namespace LifeSims2.Game
{
    public class ActivitiesMenu
    {
        /// <summary>
        /// Display Activities Main Menu
        /// </summary>
        public void MainMenu() 
        {
            Console.Clear();
            const string menuitem = "================Activities Menu================";
            const string menuitem1 = "E.) Education";
            const string menuitem2 = "H.) Health";
            const string menuitem3 = "F.) Fun";
            const string menuitem4 = "B.) Bad";
            const string menuitem5 = "Q.) Exit";

            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem3.Length / 2) + "}", menuitem3);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem4.Length / 2) + "}", menuitem4);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem5.Length / 2) + "}", menuitem5);
            Console.WriteLine("Select what are you going to do");
            ActivitiesChoice();
        }

        /// <summary>
        /// display a list of each activity
        /// </summary>
        public void ActivitiesChoice() 
        {
            var ActInput = Console.ReadLine();
            switch (ActInput.ToLower())
            {
                case "e":
                    var EduMain = new EducationAct();
                    var EduActs = EduMain.CreateEduList();
                    EduMain.ShowList(EduActs);
                    break;
                case "h":
                    var HealthMain = new HealthAct();
                    var HealthAct = HealthMain.CreateHealthList();
                    HealthMain.PrintHealthAct(HealthAct);
                    break;
                case "f":
                    var FunMain = new FunActs();
                    FunMain.FunActsMenu();
                    break;
                case "b":
                    var BadMain = new BadActs();
                    BadMain.BadActsMenu();
                    break;
                case "q":
                    break;
                default:
                    MainMenu();
                    break;
            }
        }



    }
}