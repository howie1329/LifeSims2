using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using LifeSims2.Data;

namespace LifeSims2.Game
{
    public class MainGame
    {
        private readonly List<string> History = new List<string>();
        Disease Disease = new Disease();

        /// <summary>
        /// Transfer UserData 
        /// </summary>
        /// <param name="info"></param>
        public MainGame(UserInfo info)
        {
            Firstname = info.FirstName;
            Lastname = info.LastName;
            City = info.City;
            Country = info.Country;
            Age = info.Age;
            AgeStatus = info.AgeStatus; // Changes based on the current age of the user
            Money = info.Money;
            Happiness = info.Happiness;
            Health = info.Health;
            Education = info.Education;
            Looks = info.Looks;
            Status = info.Status; // States if Alive or Dead
            Turns = info.Turns; // Gives 3 actions per year and is used as a counters
            JobStatus = info.JobStatus; // Sets if someone has a job or not
            Occupation = info.Occupation; // Shows what current job someone has
            CurrentSchool = info.CurrentSchool; // What current school someone goes to 
            HighSchoolD = info.HighSchoolD; // when someone graduates highschool this records their diploma
            AttendHighSchool = info.AttendHighSchool; // is true when someone is currently in highschool
            CommunityCollegeD = info.CommunityCollegeD; // is true when someone graduates community college
            AttendCommunityCollege = info.AttendCommunityCollege; //  is set when someone attends community college
            EducationUniversityD = info.EducationUniversityD; // true when someone graduates for education university
            AttendEducationUniversity =
                info.AttendEducationUniversity; // true when someone attends education university
            HealthUniversityD = info.HealthUniversityD; // true when someone graduates from health university
            GovernmentUniversityD = info.GovernmentUniversityD; // true when graduates from government university
            CommunityCollegeTime = info.CommunityCollegeTime; // records the time in community college 
            EducationUniversityTime = info.EducationUniversityTime; // records the time in education university
            HealthUniversityTime = info.HealthUniversityTime; // records the time in health university
            AttendHealthUniversity = info.AttendHealthUniversity; // set true if user attends health university
            GovernmentUniversityTime = info.GovernmentUniversityTime; // records time in government univeristy
            AttendGovernmentUniversity =
                info.AttendGovernmentUniversity; //set true if user attends government university
            GainMoney = info.GainMoney;
            Sal = info.Sal;
            DiseaseName = info.DiseaseName;
            DiseaseEffect = info.DiseaseEffect;
            CurrentState = info.CurrentState;
        }

        /// <summary>
        /// UserData 
        /// </summary>
        private string Firstname { get; }
        private string Lastname { get; }
        private string City { get; }
        private string Country { get; }
        private int Happiness { get; set; }
        private int Health { get; set; }
        private int Education { get; set; }
        private int Looks { get; set; }
        private int Age { get; set; }
        private string AgeStatus { get; set; }
        private double Money { get; set; }
        private double GainMoney { get; set; }
        private bool Status { get; }
        private int Turns { get; set; }
        private bool JobStatus { get; set; }
        private string Occupation { get; set; }
        private double Sal { get; set; }
        private string CurrentSchool { get; set; }
        private bool HighSchoolD { get; }
        private bool CommunityCollegeD { get; set; }
        private int CommunityCollegeTime { get; set; }
        private bool EducationUniversityD { get; set; }
        private int EducationUniversityTime { get; set; }
        private bool HealthUniversityD { get; set; }
        private int HealthUniversityTime { get; set; }
        private bool GovernmentUniversityD { get; set; }
        private int GovernmentUniversityTime { get; set; }
        private bool AttendHighSchool { get; set; }
        private bool AttendCommunityCollege { get; set; }
        private bool AttendEducationUniversity { get; set; }
        private bool AttendHealthUniversity { get; set; }
        private bool AttendGovernmentUniversity { get; set; }
        private string DiseaseName { get; set; }
        private int DiseaseEffect { get; set; }
        private string CurrentState { get; set; }

        /// <summary>
        /// takes a turn away after each event and if turns = 0 then age + 1
        /// </summary>
        private void TurnsCheck()
        {
            Turns = Turns - 1;
            if (Turns == 0) AgeUp();
        }

        /// <summary>
        /// Main Game Loop
        /// </summary>
        public void MainGameLoop()
        {
            Heading();
            GameLoop();
            Console.WriteLine("Game Over");
            Console.ReadKey();
            Environment.Exit(0);
        }

        /// <summary>
        /// // Event Loop dependent on age
        /// </summary>
        private void Events() 
        {
            string HistoryCollect;
            Random rnd = new Random();
            var random = rnd.Next(0, 10);
            switch (random)
            {
                case 0:
                    Console.WriteLine("You Broke your parents car at the age of " + Age);
                    break;
                case 1:
                    Console.WriteLine("You got into a fight....");
                    Health = Health - 4;
                    Looks = Looks - 5;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
            switch (Age)
            {
                case 3:
                    HistoryCollect = "You have been enrolled in Pre-K at the age of " + Age;
                    CurrentSchool = "Pre-K";
                    History.Add(HistoryCollect);
                    Console.WriteLine(HistoryCollect);
                    Console.ReadKey();
                    break;
                case 6:
                    HistoryCollect = "You have been enrolled in Elementary School at the age of " + Age;
                    CurrentSchool = "Elementary School";
                    History.Add(HistoryCollect);
                    Console.WriteLine(HistoryCollect);
                    Console.ReadKey();
                    break;
                case 11:
                    HistoryCollect = "You are now in Middle School at the age of " + Age;
                    CurrentSchool = "MiddleSchool";
                    History.Add(HistoryCollect);
                    Console.WriteLine(HistoryCollect);
                    Console.ReadKey();
                    break;
                case 14:
                    HistoryCollect = "You are now in High School at the age of " + Age;
                    CurrentSchool = "HighSchool";
                    AttendHighSchool = true;
                    History.Add(HistoryCollect);
                    Console.WriteLine(HistoryCollect);
                    Console.ReadKey();
                    break;
                case 18:
                    if ((Age == 18) & (Education >= 60) & AttendHighSchool)
                    {
                        AttendHighSchool = false;
                        HistoryCollect = "You have gained your HighSchool GED at the age of " + Age;
                        CurrentSchool = "None";
                        History.Add(HistoryCollect);
                        Console.WriteLine(HistoryCollect);
                        Console.ReadKey();
                    }
                    else if ((Age == 18) & (Education < 60) & AttendHighSchool)
                    {
                        AttendHighSchool = false;
                        HistoryCollect = "You did not graduate HighSchool at the age of " + Age;
                        CurrentSchool = "None";
                        History.Add(HistoryCollect);
                        Console.WriteLine(HistoryCollect);
                        Console.ReadKey();
                    }

                    break;
            }
        }

        /// <summary>
        /// GamePlay Loop
        /// </summary>
        private void GameLoop()
        {
            var Info = new UserInfo();
            do
            {
                Info.HealthCheck();
                DiseaseEvent();
                Events();
                Heading();
            } while (Health > 0);
        }

        /// <summary>
        /// Creates Disease Event
        /// </summary>
        private void DiseaseEvent()
        {
            Random rnd = new Random();
            if (CurrentState == "Healthy")
            {
                var chance = rnd.Next(0, 5);
                if (chance == 3 )
                {
                    GetDisease();
                }
            }else if (CurrentState == "Sick")
            {
                Health = Health - 5;
            }else if (CurrentState == "Dying")
            {
                Health = Health - 10;
            }
        }

        /// <summary>
        /// Giving the player a chance at getting a disease
        /// </summary>
        private void GetDisease()
        {
            var DiseaseList = Disease.CreateDiseases();
            Random rnd = new Random();
            var DiseaseNumber = rnd.Next(0, 6);

            DiseaseName = DiseaseList[DiseaseNumber].DiseaseName;
            DiseaseEffect = DiseaseList[DiseaseNumber].DiseaseEffect;
            CurrentState = DiseaseList[DiseaseNumber].PlayerHealthState;
            DiseaseAffect();
        }

        /// <summary>
        /// Determines how a disease and it affects take place
        /// </summary>
        private void DiseaseAffect()
        {
            Health = Health - DiseaseEffect;
            if (CurrentState == "Healthy")
            {
                Health = Health;
            }else if (CurrentState == "Sick")
            {
                Health = Health - 5;
            }
            else if (CurrentState == "Dying")
            {
                Health = Health - 10;
            }
           
        }

        /// <summary>
        /// Heading UI Display
        /// </summary>
        private void Heading() 
        {
            Console.Clear();
            var heading = $"{Firstname} {Lastname} Age:{Age} Money:{Money} From:{City},{Country} ";
            var heading2 =
                $"Happiness:{Happiness} Heath:{Health} Education:{Education} Looks:{Looks} Status:{AgeStatus}";
            var heading3 = $"TurnsLeft: {Turns} School: {CurrentSchool} Occupation: {Occupation}";
            var heading4 = $"Disease: {DiseaseName} Health State: {CurrentState}";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + heading.Length / 2) + "}", heading);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + heading2.Length / 2) + "}", heading2);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + heading3.Length / 2) + "}", heading3);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + heading4.Length / 2) + "}", heading4);
            Menu();
        }

        /// <summary>
        /// Menu
        /// </summary>
        private void Menu() 
        {
            const string menuitem = "================Menu================";
            const string menuitem1 = "J.) Jobs";
            const string menuitem2 = "S.) Assets";
            const string menuitem3 = "A.) Activities";
            const string menuitem4 = "R.) Relationships";
            const string menuitem5 = "U.) Age Up";
            const string menuitem6 = "H.) History";
            const string menuitem7 = "E.) Save Game";
            const string menuitem8 = "Q.) Quit Game";

            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem3.Length / 2) + "}", menuitem3);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem4.Length / 2) + "}", menuitem4);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem5.Length / 2) + "}", menuitem5);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem6.Length / 2) + "}", menuitem6);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem7.Length / 2) + "}", menuitem7);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem8.Length / 2) + "}", menuitem8);
            Console.WriteLine("Select what are you going to do");
            Choice();
        }

        /// <summary>
        /// Allows the user to choose something in the menu
        /// </summary>
        private void Choice() 
        {
            var MainJobs = new MainJobMenu();
            var Activities = new ActivitiesMenu();
            var ChoiceInput = Console.ReadLine();

            switch (ChoiceInput.ToUpper())
            {
                case "J":
                    TurnsCheck();
                    if (Age >= 16)
                    {
                        if (JobStatus == false)
                        {
                            MainJobs.MJobMenu();
                            Console.WriteLine("Which job are you applying for...");
                            var JobChoice = Console.ReadLine();
                            JobPick(JobChoice);
                        }
                        else
                        {
                            Console.WriteLine("You already have a job you must quit before getting a new one...");
                            Console.WriteLine("Would You Like To Quit? Yes or No");
                            var Quit = Console.ReadLine();
                            if (Quit.ToLower() == "Yes" || Quit.ToLower() == "yes")
                            {
                                Console.WriteLine("You have quit your job");
                                Occupation = "None";
                                GainMoney = 0;
                                JobStatus = false;
                                Console.ReadKey();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are to young, comeback when you are 16");
                        Console.ReadKey();
                    }
                    break;
                case "S":
                    TurnsCheck();
                    break;
                case "A":
                    TurnsCheck();
                    Activities.MainMenu();
                    Console.WriteLine("What are you going to do?");
                    var ActivitiesInput = Console.ReadLine();
                    ActPick(ActivitiesInput);
                    break;
                case "R":
                    TurnsCheck();
                    break;
                case "U":
                    AgeUp();
                    GiveMoney();
                    break;
                case "H":
                    Console.Clear();
                    foreach (var VARIABLE in History) Console.WriteLine(VARIABLE);
                    Console.ReadKey();
                    break;
                case "E":
                    Console.Clear();
                    SaveGame();
                    Console.WriteLine("You have saved your game...");
                    break;
                case "Q":
                    Console.Clear();
                    Console.WriteLine("Thanks for Playing...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    if (string.IsNullOrWhiteSpace(ChoiceInput)) Heading();

                    break;
            }
        }

        /// <summary>
        /// When the user is ready or turns = 0
        /// </summary>
        private void AgeUp()  
        {
            var rnd = new Random();
            Age = Age + 1;
            Turns = 3;
            EduCheck();
            EduGrad();
            EdcKick();
            ZeroCheck();
            AgeStatusChange();
            Education = Education - rnd.Next(0, 3);
            Happiness = Happiness - rnd.Next(0, 3);
            Health = Health - rnd.Next(0, 3);
            Looks = Looks - rnd.Next(0, 3);
        }

        /// <summary>
        /// Stops variables from falling below zero
        /// </summary>
        private void ZeroCheck()
        {
            if (Education <= 0)
            {
                Education = 0;
            }else if (Health <= 0)
            {
                Health = 0;
            }else if (Looks <= 0)
            {
                Looks = 0;
            }else if (Happiness <= 0)
            {
                Happiness = 0;
            }
        }

        /// <summary>
        /// When turns = 4 years the user graduates and is given a degree
        /// </summary>
        private void EduGrad()
        {
            if (CommunityCollegeTime == 4)
            {
                AttendCommunityCollege = false;
                CommunityCollegeD = true;
                CommunityCollegeTime = 0;
                var output = "You have gained your Community College Degree at the age of " + Age;
                History.Add(output);
                Console.WriteLine(output);
            }
            else if (EducationUniversityTime == 4)
            {
                AttendEducationUniversity = false;
                EducationUniversityD = true;
                EducationUniversityTime = 0;
                var output = "You have gained your Education Degree at the age of " + Age;
                History.Add(output);
                Console.WriteLine(output);
            }
            else if (HealthUniversityTime == 4)
            {
                AttendHealthUniversity = false;
                HealthUniversityD = true;
                HealthUniversityTime = 0;
                var output = "You have gained your Health Degree at the age of " + Age;
                History.Add(output);
                Console.WriteLine(output);
            }
            else if (GovernmentUniversityTime == 4)
            {
                AttendGovernmentUniversity = false;
                GovernmentUniversityD = true;
                GovernmentUniversityTime = 0;
                var output = "You have gained your Government Degree at the age of " + Age;
                History.Add(output);
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// once into a school 1 year is added to their time
        /// </summary>
        private void EduCheck() 
        {
            if (AttendCommunityCollege)
                CommunityCollegeTime = CommunityCollegeTime + 1;
            else if (AttendEducationUniversity)
                EducationUniversityTime = EducationUniversityTime + 1;
            else if (AttendGovernmentUniversity)
                GovernmentUniversityTime = GovernmentUniversityTime + 1;
            else if (AttendHealthUniversity) HealthUniversityTime = HealthUniversityTime + 1;
        }

        /// <summary>
        /// if their education level becomes to low they are kicked out from their school
        /// </summary>
        private void EdcKick()
        {
            if (AttendHighSchool & (Education < 35))
            {
                AttendHighSchool = false;
                var history = "You have been kicked out of HighSchool for low grades at the age of " + Age;
                History.Add(history);
                CurrentSchool = "None";
                Console.WriteLine(history);
                Console.ReadKey();
            }
            else if (AttendCommunityCollege & (Education < 40))
            {
                AttendCommunityCollege = false;
                var history = "You have been kicked out of Community College for bad grades at the age of " + Age;
                History.Add(history);
                CurrentSchool = "None";
                Console.WriteLine(history);
                Console.ReadKey();
            }
            else if (AttendEducationUniversity & (Education < 60))
            {
                AttendEducationUniversity = false;
                var history = "You have been kicked out of Education University for low grades at the age of " + Age;
                History.Add(history);
                CurrentSchool = "None";
                Console.WriteLine(history);
                Console.ReadKey();
            }
            else if (AttendHealthUniversity & (Education < 70))
            {
                AttendHealthUniversity = false;
                var history = "You have been kicked out of Health University for low grades at the age of " + Age;
                History.Add(history);
                CurrentSchool = "None";
                Console.WriteLine(history);
                Console.ReadKey();
            }
            else if (AttendGovernmentUniversity & (Education < 80))
            {
                AttendGovernmentUniversity = false;
                var history = "You have been kicked out of Government University for low grades at the age of " +
                              Age;
            }
        }

        /// <summary>
        /// Gives the user the option to pick an activity
        /// </summary>
        /// <param name="input"></param>
        private void ActPick(string input) 
        {
            var EduMain = new EducationAct();
            var EduActs = EduMain.CreateEduList();
            var HealthMain = new HealthAct();
            var HealthActs = HealthMain.CreateHealthList();
            var FunMain = new FunActs();
            var FunActs = FunMain.VacationSpotsList();
            string HistoryOutput;
            switch (input.ToLower())
            {
                case "community college":
                    if (Education >= 40 & Age > 18)
                    {
                        Console.Clear();
                        HistoryOutput = "You have enrolled in Community College at the age of " + Age;
                        AttendCommunityCollege = true;
                        CurrentSchool = EduActs[2].ActivitiesName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You do not have the grades for Community");
                        Console.ReadKey();
                    }

                    break;
                case "education university":
                    if (Education >= 60 & Age > 18)
                    {
                        Console.Clear();
                        HistoryOutput = "You have enrolled in Education University at the age of " + Age;
                        AttendEducationUniversity = true;
                        CurrentSchool = EduActs[3].ActivitiesName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You do not have the grades for Education University");
                        Console.ReadKey();
                    }

                    break;
                case "health university":
                    if (Education >= 70 & Age > 18)
                    {
                        Console.Clear();
                        HistoryOutput = "You have enrolled in Health University at the age of " + Age;
                        AttendHealthUniversity = true;
                        CurrentSchool = EduActs[4].ActivitiesName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You do not have the grades for Health University");
                        Console.ReadKey();
                    }

                    break;
                case "government university":
                    if (Education >= 80 & Age > 18)
                    {
                        Console.Clear();
                        HistoryOutput = "You have enrolled in Government University at the age of " + Age;
                        AttendGovernmentUniversity = true;
                        CurrentSchool = EduActs[5].ActivitiesName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You do not have the grades for Government University");
                        Console.ReadKey();
                    }

                    break;
                case "study at the library":
                    if (Age >= 7)
                    {
                        Console.Clear();
                        HistoryOutput = "You've Studied at the Library," + Age;
                        Console.WriteLine(HistoryOutput);
                        Education = Education + EduActs[0].EducationBenefits;
                        Happiness = Happiness - EduActs[0].HappinessBenefits;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough to use the library. Come back when your 7.");
                        Console.ReadKey();
                    }

                    break;
                case "take a course":
                    if (Age >= 14)
                    {
                        Console.Clear();
                        HistoryOutput = "You took a course," + Age;
                        Console.WriteLine(HistoryOutput);
                        Education = Education + EduActs[1].EducationBenefits;
                        Happiness = Happiness - EduActs[1].HappinessBenefits;
                        Console.ReadKey();
                        AgeUp();
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough to take a course. Come back when your 14.");
                        Console.ReadKey();
                    }
                    break;
                case "dr.sam":
                    Health = Health + HealthActs[0].HealthBenefits;
                    Money = Money - HealthActs[0].Cost;
                    CureDisease();
                    break;
                case "dr.mike":
                    Health = Health + HealthActs[1].HealthBenefits;
                    Money = Money - HealthActs[1].Cost;
                    CureDisease();
                    break;
                case "hospital":
                    Health = Health + HealthActs[2].HealthBenefits;
                    Money = Money - HealthActs[2].Cost;
                    CureDisease();
                    break;
                case "hawaii":
                    Happiness = Happiness + FunActs[0].VacationEffect;
                    Money = Money - FunActs[0].VacationCost;
                    AgeUp();
                    break;
                case "paris":
                    Happiness = Happiness + FunActs[1].VacationEffect;
                    Money = Money - FunActs[1].VacationCost;
                    AgeUp();
                    break;
                case "london":
                    Happiness = Happiness + FunActs[2].VacationEffect;
                    Money = Money - FunActs[2].VacationCost;
                    AgeUp();
                    break;
                case "rome":
                    Happiness = Happiness + FunActs[3].VacationEffect;
                    Money = Money - FunActs[3].VacationCost;
                    AgeUp();
                    break;
                case "male":
                    if (Age >= 18)
                    {
                        Happiness = Happiness + 5;
                        Console.WriteLine("You had sex with a guy as the age of " + Age);
                        Console.ReadKey();
                        GetDisease();
                        AgeUp();
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }
                    break;
                case "female":
                    if (Age >= 18)
                    {
                        Happiness = Happiness + 5;
                        Console.WriteLine("You had sex with a female... at the age of " + Age);
                        Console.ReadKey();
                        GetDisease();
                        AgeUp();
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }
                    break;
                case "threesome":
                    if (Age >= 18)
                    {
                        Happiness = Happiness + 5;
                        Console.WriteLine("You had a threesome at the age of" + Age);
                        Console.ReadKey();
                        GetDisease();
                        AgeUp();
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }
                   
                    break;
                case "draw 3":
                    if (Age >= 18 )
                    {
                        Money = Money - 5;
                        Draw3Game();
                        Turns = Turns - 2;
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }
                    break;
                case "draw 5":
                    if (Age >= 18)
                    {
                        Money = Money - 10;
                        Draw5Game();
                        Turns = Turns - 2;
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }

                    break;
                case "night club":
                    if (Age >= 18)
                    {
                        Money = Money - 20;
                        Happiness = Happiness + 10;
                        AgeUp();
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }

                    break;
                case "under ground":
                    if (Age >= 18)
                    {
                        Money = Money - 20;
                        Happiness = Happiness + 10;
                        AgeUp();
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }
                    break;
                case "beer":
                    if (Age >= 18)
                    {
                        Money = Money - 5;
                        Happiness = Happiness + 5;
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }
                    break;
                case "whiskey":
                    if (Age >= 18)
                    {
                        Money = Money - 7;
                        Happiness = Happiness + 7;
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }
                    break;
                case "vodka":
                    if (Age >= 18)
                    {
                        Money = Money - 10;
                        Happiness = Happiness + 10;
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 18");
                        Console.ReadKey();
                    }
                    break;
                case "weed":
                    if (Age >= 16)
                    {
                        Money = Money - 25;
                        Happiness = Happiness + 10;
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 16");
                        Console.ReadKey();
                    }
                    break;
                case "crack":
                    if (Age >= 16)
                    {
                        Money = Money - 35;
                        Happiness = Happiness + 14;
                    }
                    else
                    {
                        Console.WriteLine("Your not old enough... comeback when your 16");
                        Console.ReadKey();
                    }
                    break;
            }
        }

        /// <summary>
        /// Creates Draw 3 game
        /// </summary>
        private void Draw3Game()
        {
            Random rnd = new Random();
            double Winnings = 0;
            Console.WriteLine("What is your first number?");
            var Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            var Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your third number?");
            var Number3 = Convert.ToInt32(Console.ReadLine());

            var ComputerNumber1 = rnd.Next(0, 10);
            var ComputerNumber2 = rnd.Next(0, 10);
            var ComputerNumber3 = rnd.Next(0, 10);

            if (Number1 == ComputerNumber1)
            {
                Winnings = Winnings + 10;
            }

            if (Number2 == ComputerNumber2)
            {
                Winnings = Winnings + 10;
            }

            if (Number3 == ComputerNumber3)
            {
                Winnings = Winnings + 10;
            }

            if (Winnings == 30)
            {
                Winnings = Winnings * 2;
            }

            Money = Money + Winnings;

            Console.WriteLine("Lottery Ticket...");
            Console.WriteLine($"Your Numbers: {Number1}, {Number2}, {Number3}");
            Console.WriteLine($" Win Numbers: {ComputerNumber1}, {ComputerNumber2}, {ComputerNumber3}");
            Console.WriteLine($"Your Winnings: {Winnings}");
            Console.WriteLine("Press Enter to receive your winnings...");
           
        }

        /// <summary>
        /// Creates Draw 5 Game
        /// </summary>
        private void Draw5Game()
        {
            Random rnd = new Random();
            double Winnings = 0;
            Console.WriteLine("What is your first number?");
            var Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            var Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your third number?");
            var Number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your third number?");
            var Number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your third number?");
            var Number5 = Convert.ToInt32(Console.ReadLine());

            var ComputerNumber1 = rnd.Next(0, 10);
            var ComputerNumber2 = rnd.Next(0, 10);
            var ComputerNumber3 = rnd.Next(0, 10);
            var ComputerNumber4 = rnd.Next(0, 10);
            var ComputerNumber5 = rnd.Next(0, 10);

            if (Number1 == ComputerNumber1)
            {
                Winnings = Winnings + 10;
            }

            if (Number2 == ComputerNumber2)
            {
                Winnings = Winnings + 10;
            }

            if (Number3 == ComputerNumber3)
            {
                Winnings = Winnings + 10;
            }

            if (Number4 == ComputerNumber4)
            {
                Winnings = Winnings + 10;
            }

            if (Number5 == ComputerNumber5)
            {
                Winnings = Winnings + 10;
            }
            if (Winnings == 50)
            {
                Winnings = Winnings * 2;
            }

            Money = Money + Winnings;

            Console.WriteLine("Lottery Ticket...");
            Console.WriteLine($"Your Numbers: {Number1}, {Number2}, {Number3}, {Number4}, {Number5}");
            Console.WriteLine($" Win Numbers: {ComputerNumber1}, {ComputerNumber2}, {ComputerNumber3}, {ComputerNumber4}, {ComputerNumber5}");
            Console.WriteLine($"Your Winnings: {Winnings}");
            Console.WriteLine("Press Enter to receive your winnings...");
        }

        /// <summary>
        /// Gives the doctors the ability to cure diseases
        /// </summary>
        private void CureDisease()
        {
            if (CurrentState == "Dying")
            {
                Console.WriteLine("There is nothing the doctor can do....");
                Console.ReadKey();
            }
            else if (CurrentState == "Sick")
            {
                CurrentState = "Healthy";
                DiseaseName = "None";
            }
            else if (CurrentState == "Healthy")
            {
                Console.WriteLine("There is nothing wrong");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// gives the user the option to apply to a job
        /// </summary>
        /// <param name="input"></param>
        private void JobPick(string input) 
        {
            var EduJob = new EduJobs();
            var EduJobList = EduJob.CreateEduJobList();
            var GovJob = new GovJobs();
            var GovJovList = GovJob.CreateGovJobs();
            var HealthJob = new HealthJobs();
            var HealthJobList = HealthJob.CreateHealthJobs();
            var LowEndJob = new LowEndJobs();
            var LowEndJobList = LowEndJob.CreateLowEndJobs();
            var DarkJob = new DarkJobs();
            var DarkJobList = DarkJob.CreateDarkJobsList();
            string HistoryOutput;
            switch (input.ToLower())
            {
                case "receptionist":
                    if (HighSchoolD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Receptionist at the age of " + Age;
                        Occupation = GovJovList[0].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = GovJovList[0].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "police officer":
                    if (HighSchoolD & GovernmentUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Police Officer at the age of " + Age;
                        Occupation = GovJovList[1].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = GovJovList[1].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }
                    break;
                case "social worker":
                    if (HighSchoolD & GovernmentUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Social Worker at the age of " + Age;
                        Occupation = GovJovList[2].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = GovJovList[2].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "government lawyer":
                    if (HighSchoolD & GovernmentUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Government Lawyer at the age of " + Age;
                        Occupation = GovJovList[3].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = GovJovList[3].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "president":
                    if (HighSchoolD & GovernmentUniversityD & HealthUniversityD & EducationUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become the President at the age of " + Age;
                        Occupation = GovJovList[4].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = GovJovList[4].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "teacher":
                    if (HighSchoolD & EducationUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a teacher at the age of " + Age;
                        Occupation = EduJobList[1].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = EduJobList[2].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "daycare worker":
                    if (HighSchoolD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a daycare worker at the age of " + Age;
                        Occupation = EduJobList[0].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = EduJobList[0].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "professor":
                    if (HighSchoolD & EducationUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Professor at the age of " + Age;
                        Occupation = EduJobList[2].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = EduJobList[2].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "principal":
                    if (HighSchoolD & EducationUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Principal at the age of " + Age;
                        Occupation = EduJobList[3].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = EduJobList[3].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "special ed. worker":
                    if (HighSchoolD & EducationUniversityD & GovernmentUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Special Ed. Worker at the age of " + Age;
                        Occupation = EduJobList[4].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = EduJobList[4].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "nurse":
                    if (HighSchoolD & HealthUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Nurse at the age of " + Age;
                        Occupation = HealthJobList[0].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = HealthJobList[0].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "physical therapist":
                    if (HighSchoolD & HealthUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Physical Therapist at the age of " + Age;
                        Occupation = HealthJobList[1].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = HealthJobList[1].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "pediatrician":
                    if (HighSchoolD & HealthUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Pediatrician at the age of " + Age;
                        Occupation = HealthJobList[2].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = HealthJobList[2].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "gynecologist":
                    if (HighSchoolD & HealthUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Gynecologist at the age of " + Age;
                        Occupation = HealthJobList[3].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = HealthJobList[3].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "doctor":
                    if (HighSchoolD & HealthUniversityD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Doctor at the age of " + Age;
                        Occupation = HealthJobList[4].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = HealthJobList[4].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "waiter":
                    if (HighSchoolD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Waiter at the age of " + Age;
                        Occupation = LowEndJobList[0].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = LowEndJobList[0].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "cashier":
                    if (HighSchoolD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Cashier at the age of " + Age;
                        Occupation = LowEndJobList[1].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = LowEndJobList[1].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "garbage man":
                    if (HighSchoolD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Garbage Man at the age of " + Age;
                        Occupation = LowEndJobList[2].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = LowEndJobList[2].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "maid":
                    if (HighSchoolD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Maid at the age of " + Age;
                        Occupation = LowEndJobList[3].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = LowEndJobList[3].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "nanny":
                    if (HighSchoolD)
                    {
                        Console.Clear();
                        HistoryOutput = "You have become a Nanny at the age of " + Age;
                        Occupation = LowEndJobList[4].JobName;
                        History.Add(HistoryOutput);
                        Console.WriteLine(HistoryOutput);
                        Sal = LowEndJobList[4].Sal;
                        EarnMoney(Sal);
                        Console.ReadKey();
                        JobStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("You are not ready for this job please try again later...");
                        Console.ReadKey();
                    }

                    break;
                case "drug dealer":
                    Console.Clear();
                    HistoryOutput = "You have become a Drug Dealer at the age of " + Age;
                    Occupation = DarkJobList[0].JobName;
                    History.Add(HistoryOutput);
                    Console.WriteLine(HistoryOutput);
                    Sal = DarkJobList[0].Sal;
                    EarnMoney(Sal);
                    Console.ReadKey();
                    JobStatus = true;
                    break;
                case "booster":
                    Console.Clear();
                    HistoryOutput = "You have become a Booster at the age of " + Age;
                    Occupation = DarkJobList[1].JobName;
                    History.Add(HistoryOutput);
                    Console.WriteLine(HistoryOutput);
                    Sal = DarkJobList[1].Sal;
                    EarnMoney(Sal);
                    Console.ReadKey();
                    JobStatus = true;
                    break;
                case "black market merchant":
                    Console.Clear();
                    HistoryOutput = "You have become a Black Market Merchant at the age of " + Age;
                    Occupation = DarkJobList[2].JobName;
                    History.Add(HistoryOutput);
                    Console.WriteLine(HistoryOutput);
                    Sal = DarkJobList[2].Sal;
                    EarnMoney(Sal);
                    Console.ReadKey();
                    JobStatus = true;
                    break;
                case "middle man":
                    Console.Clear();
                    HistoryOutput = "You have become a Middle Man at the age of " + Age;
                    Occupation = DarkJobList[3].JobName;
                    History.Add(HistoryOutput);
                    Console.WriteLine(HistoryOutput);
                    Sal = DarkJobList[3].Sal;
                    EarnMoney(Sal);
                    Console.ReadKey();
                    JobStatus = true;
                    break;
            }
        }

        /// <summary>
        /// Converts everything to be ready for saving
        /// </summary>
        private void SaveGame()
        {
            Console.WriteLine("Give your save a name:");
            var FileName = Console.ReadLine();
            var Happy = Convert.ToString(Happiness);
            var Health = Convert.ToString(this.Health);
            var Education = Convert.ToString(this.Education);
            var Looks = Convert.ToString(this.Looks);
            var Age = Convert.ToString(this.Age);
            var Turns = Convert.ToString(this.Turns);
            var Money = Convert.ToString(this.Money);
            var GainMoney = Convert.ToString(this.GainMoney);
            var Sal = Convert.ToString(this.Sal);
            var CommunityCollegeTime = Convert.ToString(this.CommunityCollegeTime);
            var HealthUniversityTime = Convert.ToString(this.HealthUniversityTime);
            var EducationUniversityTime = Convert.ToString(this.EducationUniversityTime);
            var GovernmentUniversityTime = Convert.ToString(this.GovernmentUniversityTime);
            var HighSchoolD = Convert.ToString(this.HighSchoolD);
            var CommunityCollegeD = Convert.ToString(this.CommunityCollegeD);
            var EducationUniversityD = Convert.ToString(this.EducationUniversityD);
            var HealthUniversityD = Convert.ToString(this.HealthUniversityD);
            var GovernmentUniversityD = Convert.ToString(this.GovernmentUniversityD);
            var AttendHighSchool = Convert.ToString(this.AttendHighSchool);
            var AttendHealthUniversity = Convert.ToString(this.AttendHealthUniversity);
            var AttendCommunityCollege = Convert.ToString(this.AttendCommunityCollege);
            var AttendEducationUniversity = Convert.ToString(this.AttendEducationUniversity);
            var AttendGovernmentUniversity = Convert.ToString(this.AttendGovernmentUniversity);
            var DiseaseName = this.DiseaseName;
            var CurrentState = this.CurrentState;
            var DiseaseEffect = Convert.ToString(this.DiseaseEffect);
            string[] SaveData =
            {
                Firstname, Lastname, City, Country, AgeStatus, Occupation, CurrentSchool, Happy, Health, Education,
                Looks, Age, Turns, CommunityCollegeTime, HealthUniversityTime, EducationUniversityTime,
                GovernmentUniversityTime,Money, GainMoney, Sal, HighSchoolD, CommunityCollegeD, EducationUniversityD,
                HealthUniversityD,GovernmentUniversityD,AttendHighSchool, AttendCommunityCollege,
                AttendEducationUniversity, AttendHealthUniversity,AttendGovernmentUniversity, DiseaseName, CurrentState, DiseaseEffect
            };
            File.WriteAllLines(@"C:\Users\howar\CodeProjects\LifesimSaveData\" + FileName + ".txt", SaveData);
        } 

        /// <summary>
        /// gives the money from a salary to the user
        /// </summary>
        private void GiveMoney()
        {
            Money = Money + GainMoney;
        }

        /// <summary>
        /// splits the salary to be used by the user
        /// </summary>
        /// <param name="sal"></param>
        private void EarnMoney(double sal) 
        {
            GainMoney = Sal / 4;
        }

        /// <summary>
        /// Changes the age status of the player based off age of the user
        /// </summary>
        public void AgeStatusChange() 
        {
            if (Age > 23)
                AgeStatus = "Adult";
            else if (Age > 17)
                AgeStatus = "Young Adult";
            else if (Age > 12)
                AgeStatus = "Teen";
            else if (Age > 4) AgeStatus = "Child";
        }
    }
}