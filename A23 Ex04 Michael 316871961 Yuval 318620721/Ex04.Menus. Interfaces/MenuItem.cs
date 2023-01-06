using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public string Header { get; set; }

        public List<MenuItem> menuOptions { get; set; }

        public ICommand[] Commands { get; set; }

        public MenuItem() { }

        public MenuItem(string header, List<MenuItem> menuItems, ICommand[] commands)
        {
            this.Header = header;
            this.menuOptions = menuItems;
            this.Commands = commands;
        }

        public void RunCommand(int choice)
        {
            Commands[choice].Run();
        }

        public void Print(List<int> choices)
        {
            if (choices.Count > 0)
            {
                menuOptions[choices.First() - 1].Print(choices.Skip(1).ToList());
            }
            else
            {
                PrintHeader();

                bool isMainMenu = choices.Count == 0;

                PrintOptions(isMainMenu);
            }
        }

        private void PrintHeader()
        {
            Console.WriteLine(string.Format("**{0}**", Header));

            for (int i = 0; i < Header.Length + 4; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }

        private void PrintOptions(bool isMainMenu)
        {
            bool isOptions = menuOptions.Count > 0;

            int range = isOptions ? menuOptions.Count : Commands.Length;

            for (int i = 0; i < range; i++)
            {
                string optionText = isOptions ? menuOptions[i].Header : Commands[i].GetCommandHeader();

                Console.WriteLine(string.Format(" {0}. {1}", i + 1, optionText));
            }

            Console.WriteLine(string.Format(" 0. {0}", (isMainMenu ? "Exit" : "Back")));
        }

        public int GetChoice(bool isMainMenu)
        {
            Console.WriteLine(string.Format("Please enter your choice (1-{0} or 0 to {1})", menuOptions.Count, (isMainMenu ? "Exit" : "Back")));

            int result = -1;

            bool inputIsValid = false;

            int range = menuOptions.Count > 0 ? menuOptions.Count : Commands.Length;

            while (!inputIsValid)
            {
                string choice = Console.ReadLine();

                if (int.TryParse(choice, out result))
                {
                    if (result > range || result < 0)
                    {
                        Console.WriteLine("Invalid input, pleas choose one of the given options above");
                    }
                    else
                    {
                        inputIsValid = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid integer");
                }
            }

            return result;
        }

    }
}
