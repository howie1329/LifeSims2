using System;

namespace LifeSims2.Game
{
    internal class Program
    {
        /// <summary>
        /// Main Start to program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.Title = "Life Sim";
            var mainMenu = new MainMenu();
            mainMenu.Menu(); // Starts the game
        }
    }
}