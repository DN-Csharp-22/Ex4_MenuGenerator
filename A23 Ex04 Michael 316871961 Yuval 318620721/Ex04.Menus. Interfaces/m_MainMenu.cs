using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class m_MainMenu
    {
        MenuItem menuItem { get; set; }

        List<string> choices { get; set; }

        public m_MainMenu(MenuItem menuItem)
        {
            this.menuItem = menuItem;
        }

        public void Show()
        {
            while (true)
            {
                PrintMenu(menuItem);

                int choice = GetChoice(menuItem.menuOptions.Count);
            }
        }

        public void PrintMenu(MenuItem menuItem)
        {
            Console.WriteLine(string.Format("**{0}**", menuItem.Header));

            for (int i = 0; i < menuItem.Header.Length; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();

            for (int i = 0; i < menuItem.menuOptions.Count; i++)
            {
                Console.WriteLine(string.Format("{0}. {1}", i, menuItem.menuOptions[i]));
            }

            string backOrExitText = choices.Count == 0 ? "Exit" : "Back";

            Console.WriteLine(string.Format("Please enter your choice (1 to {0} or 0 to {1})", menuItem.menuOptions.Count, backOrExitText));
        }

        public int GetChoice(int i_range)
        {
            int result = -1;

            bool inputIsValid = false;

            while (!inputIsValid)
            {
                string choice = Console.ReadLine();

                if (int.TryParse(choice, out result))
                {
                    if (result > i_range || result < 0)
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
