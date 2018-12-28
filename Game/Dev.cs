using System;
using System.IO;

namespace LifeSims2.Game
{
    public class Dev
    {
        public void DevMenu()
        {
            while (true)
            {
                Console.WriteLine("Create a save or Load a save");
                var DevInput = Console.ReadLine();
                switch (DevInput.ToLower())
                {
                    case "create":
                        Create();
                        break;
                    case "load":
                        Load();
                        break;
                    default:
                        continue;
                }

                break;
            }
        }

        private void Load()
        {
            Console.Clear();
            Console.WriteLine("Please type in the save name...");
            var FileName = Console.ReadLine();
            string[] File = System.IO.File.ReadAllLines(@"C:\Users\howar\CodeProjects\LifesimSaveData\" + FileName + ".txt");
            foreach (var VARIABLE in File)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("Would you like to change anything");
            var DevDecision = Console.ReadLine();
            while (DevDecision == "yes")
            {
                Console.WriteLine("What do you want to change?");
                DevDecision = Console.ReadLine();
                string change;
                switch (DevDecision.ToLower())
                {
                    case "firstname":
                        Console.WriteLine("Please type in a first name:");
                        change = Console.ReadLine();
                        File[0] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "lastname":
                        Console.WriteLine("Please type in a last name:");
                        change = Console.ReadLine();
                        File[1] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "city":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[2] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "country":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[3] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "agestatus":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[4] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "occupation":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[5] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "currentschool":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[6] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "happiness":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[7] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "health":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[8] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "education":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[9] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "looks":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[10] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "age":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[11] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "turns":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[12] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "communitytime":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[13] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "healthtime":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[14] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "educationtime":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[15] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "govtime":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[16] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "money":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[17] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "gainmoney":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[18] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "sal":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[19] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "highschoold":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[20] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "communityd":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[21] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "educationd":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[22] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "healthd":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[23] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "govd":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[24] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attendhigh":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[25] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attendc":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[26] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attende":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[27] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attendh":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[28] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attendg":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[29] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "diseasename":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[30] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "currentstate":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[31] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "diseaseeffect":
                        Console.WriteLine("Please Type Your Change:");
                        change = Console.ReadLine();
                        File[32] = change;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong input please try again");
                        Console.ReadKey();
                        break;
                }
            }

            System.IO.File.WriteAllLines(@"C:\Users\howar\CodeProjects\LifesimSaveData\" + FileName + ".txt", File);
            Console.WriteLine("Everything has been saved");
            Console.ReadKey();
        }

        private void Create()
        {
            Console.Clear();
            Console.WriteLine("Give the save a name");
            var Filename = Console.ReadLine();
            var Default = Convert.ToString(0);
            var DefaultTrueOrFalse = Convert.ToString("false");
            string[] CreateData =
                {Default, Default, Default, Default, Default, Default, Default, Default, Default, Default, Default,
                    Default, Default, Default, Default, Default, Default, Default, Default, Default, DefaultTrueOrFalse,
                    DefaultTrueOrFalse, DefaultTrueOrFalse, DefaultTrueOrFalse, DefaultTrueOrFalse, DefaultTrueOrFalse,
                    DefaultTrueOrFalse, DefaultTrueOrFalse, DefaultTrueOrFalse, DefaultTrueOrFalse,Default,Default,Default};
            File.WriteAllLines(@"C:\Users\howar\CodeProjects\LifesimSaveData\" + Filename + ".txt", CreateData);
            Console.WriteLine("Would you like to change anything?");
            var DevDecision = Console.ReadLine();
            while (DevDecision == "yes")
            {
                Console.WriteLine("What do you want to change?");
                DevDecision = Console.ReadLine();
                string DevChange;
                switch (DevDecision.ToLower())
                {
                    case "firstname":
                        Console.WriteLine("Please type in a first name:");
                        DevChange = Console.ReadLine();
                        CreateData[0] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "lastname":
                        Console.WriteLine("Please type in a last name:");
                        DevChange = Console.ReadLine();
                        CreateData[1] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "city":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[2] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "country":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[3] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "agestatus":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[4] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "occupation":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[5] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "currentschool":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[6] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "happiness":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[7] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "health":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[8] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "education":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[9] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "looks":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[10] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "age":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[11] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "turns":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[12] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "communitytime":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[13] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "healthtime":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[14] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "educationtime":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[15] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "govtime":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[16] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "money":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[17] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "gainmoney":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[18] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "sal":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[19] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "highschoold":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[20] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "communityd":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[21] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "educationd":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[22] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "healthd":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[23] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "govd":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[24] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attendhigh":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[25] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attendc":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[26] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attende":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[27] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attendh":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[28] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "attendg":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[29] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "diseasename":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[30] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "currentstate":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[31] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    case "diseaseeffect":
                        Console.WriteLine("Please Type Your Change:");
                        DevChange = Console.ReadLine();
                        CreateData[32] = DevChange;
                        Console.WriteLine("Want to change anything else?");
                        DevDecision = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong input please try again");
                        Console.ReadKey();
                        break;
                }
            }

            File.WriteAllLines(@"C:\Users\howar\CodeProjects\LifesimSaveData\" + Filename + ".txt", CreateData);
            Console.WriteLine("Everything has been saved");
            Console.ReadKey();
        }
    }
}