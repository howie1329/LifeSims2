using System;
using LifeSims2.Data;

namespace LifeSims2.Game
{
    public class MainMenu
    {
        public void Menu() // Start Screen UI
        {
            var create = new Create(); // Allows access to the create class
            var load = new Loadgame(); // Allows access to the Loadgame Class
            var dev = new Dev();
            var heading = "Welcome to Life Sim";
            var heading2 = "New Game or Load Old Game";
            var heading3 = "Type What You Would Like To Do...";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + heading.Length / 2) + "}", heading);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + heading2.Length / 2) + "}", heading2);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + heading3.Length / 2) + "}", heading3);
            var input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "new game":
                    create.Creation();
                    break;
                case "load game":
                    load.Load();
                    break;
                case "dev":
                    dev.DevMenu();
                    break;
                default:
                    Console.WriteLine("Game Closing....");
                    break;
            }
            Console.ReadKey();

            // Runs the creation method in the create class
        }
    }
}