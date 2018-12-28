using System;
using System.IO;
using LifeSims2.Data;

namespace LifeSims2.Game
{
    public class Create
    {
        /// <summary>
        /// Allows access to the UserInfo Class
        /// </summary>
        private readonly UserInfo _user = new UserInfo();

        /// <summary>
        /// Creates a new player
        /// </summary>
        public void Creation()
        {
            Console.Clear();
            Console.WriteLine("Type in a FirstName:");
            _user.FirstName = Console.ReadLine();
            Console.WriteLine("Type in a LastName:");
            _user.LastName = Console.ReadLine();
            Console.WriteLine("What City Are You From");
            _user.City = Console.ReadLine();
            Console.WriteLine("What Country Are You From");
            _user.Country = Console.ReadLine();
            var Game = new MainGame(_user);
            Game.MainGameLoop();
            Console.ReadKey();
        }
    }
}