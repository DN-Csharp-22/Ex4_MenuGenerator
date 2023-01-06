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

        public void RunCommand(List<int> choices, int choice)
        {
            if (menuOptions.Count > 0)
            {
                menuOptions[choices.First() - 1].RunCommand(choices.Skip(1).ToList(), choice);
            }
            else
            {
                Commands[choice].Run();
            }
        }

        public void Print(List<int> choices, bool isMainMenu = false)
        {
            if (choices.Count > 0)
            {
                menuOptions[choices.First() - 1].Print(choices.Skip(1).ToList());
            }
            else
            {
                PrintHeader();

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

        public MenuItem GetCurrnetMenuItem(List<int> choices)
        {
            if (choices.Count >= 1)
            {
                return menuOptions[choices.First() - 1].GetCurrnetMenuItem(choices.Skip(1).ToList());
            }
            else
            {
                return this;
            }
        }

        public int GetChoice(List<int> choices, out ICommand command)
        {
            command = null;

            MenuItem currentMenuItem = GetCurrnetMenuItem(choices);

            bool isCommand = currentMenuItem.Commands.Length > 0;

            bool isMainMenu = choices.Count == 0;

            int inputMaxRange = isCommand ? currentMenuItem.Commands.Length : currentMenuItem.menuOptions.Count;

            Console.WriteLine(string.Format("Please enter your choice (1-{0} or 0 to {1})", inputMaxRange, (isMainMenu ? "Exit" : "Back")));

            int choice = -1;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 0 && choice <= inputMaxRange)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, pleas choose one of the given options above");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid integer");
                }
            }

            if (choice > 0 && isCommand)
            {
                command = currentMenuItem.Commands[choice - 1];
            }

            return choice;
        }

    }
}
