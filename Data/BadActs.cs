using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace LifeSims2.Data
{
    class BadActs
    {
        public string BadActsName { get; set; }

        public void BadActsMenu()
        {
            Console.Clear();
            const string menuitem = "================Bad Acts================";
            const string menuitem1 = "Drinking";
            const string menuitem2 = "Drugs";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
            Console.WriteLine("What are you going to do?");
            BadPick();
        }

        public void BadPick()
        {
            var ActInput = Console.ReadLine();
            switch (ActInput.ToLower())
            {
                case "drinking":
                    Drinking();
                    break;
                case "drugs":
                    Drugs();
                    break;
               default:
                   BadActsMenu();
                   break;
            }
        }

        public void Drinking()
        {
            const string menuitem = "================Drink Menu================";
            const string menuitem1 = "Beer";
            const string menuitem2 = "Whiskey";
            const string menuitem3 = "Vodka";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem3.Length / 2) + "}", menuitem3);
        }

        public void Drugs()
        {
            const string menuitem = "================Drugs================";
            const string menuitem1 = "Weed";
            const string menuitem2 = "Crack";
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem.Length / 2) + "}", menuitem);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem1.Length / 2) + "}", menuitem1);
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + menuitem2.Length / 2) + "}", menuitem2);
        }
    }
}
