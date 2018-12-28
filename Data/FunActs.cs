using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeSims2.Game;

namespace LifeSims2.Data
{
    class FunActs
    {
        public string VacationLocation { get; set; }
        public double VacationCost { get; set; }
        public int VacationEffect { get; set; }

        
        public void FunActsMenu()
        {
            Console.Clear();
            const string menuitem = "================Fun Menu================";
            const string menuitem1 = "V.) Vacations";
            const string menuitem2 = "S.) Sex";
            const string menuitem3 = "C.) Clubbing";
            const string menuitem4 = "L.) Lottery";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem3.Length / 2) + "}", menuitem3);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem4.Length / 2) + "}", menuitem4);
            Console.WriteLine("What are you going to do?");
            FunActPick();
        }

        public void FunActPick()
        {
            
            var ActInput = Console.ReadLine();
            switch (ActInput.ToLower())
            {
                case "v":
                    VacationMenu();
                    break;
                case "s":
                    SexMenu();
                    break;
                case "c":
                    ClubbingMenu();
                    break;
                case "l":
                    LotteryMenu();
                    break;
            }
        }

        public void VacationMenu()
        {
            Console.Clear();
            const string menuitem = "================Vacations================";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            var va = VacationSpotsList();
            ShowVacationSpots(va);
            Console.WriteLine("Where would you like to go?");

        }

        public FunActs[] VacationSpotsList()
        {
            FunActs [] Vacations = new FunActs[4];
            Vacations[0] = new FunActs();
            Vacations[0].VacationLocation = "Hawaii";
            Vacations[0].VacationCost = 4000;
            Vacations[0].VacationEffect = 10;
            Vacations[1] = new FunActs();
            Vacations[1].VacationLocation = "Paris";
            Vacations[1].VacationCost = 8000;
            Vacations[1].VacationEffect = 15;
            Vacations[2] = new FunActs();
            Vacations[2].VacationLocation = "London";
            Vacations[2].VacationCost = 10000;
            Vacations[2].VacationEffect = 15;
            Vacations[3] = new FunActs();
            Vacations[3].VacationLocation = "Rome";
            Vacations[3].VacationCost = 12000;
            Vacations[3].VacationEffect = 20;
            return Vacations;
        }

        public void ShowVacationSpots(FunActs[] Vacations)
        {
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine(Vacations[i].VacationLocation);
                Console.WriteLine("Cost:" + Vacations[i].VacationCost);
                Console.WriteLine("----------------------");
            }
        }

        public void ClubbingMenu()
        {
            const string menuitem = "================Clubbing Menu================";
            const string menuitem1 = "Night Club";
            const string menuitem2 = "Under Ground";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
        }

        public void SexMenu()
        {
            Console.Clear();
            const string menuitem = "================Sex Menu================";
            const string menuitem1 = "Male";
            const string menuitem2 = "Female";
            const string menuitem3 = "Threesome";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem3.Length / 2) + "}", menuitem3);
        }

        public void LotteryMenu()
        {
            const string menuitem = "================Lottery Menu================";
            const string menuitem1 = "Draw 3 Cost: $5";
            const string menuitem2 = "Draw 5 Cost: $10";

            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
        }
    }
}
