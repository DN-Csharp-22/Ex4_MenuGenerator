using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class m_MainMenu
    {
        MenuItem menu { get; set; }

        List<int> choices { get; set; }

        public m_MainMenu(MenuItem menuItem)
        {
            this.menu = menuItem;
            this.choices = new List<int>();
        }

        public void Show()
        {
            while (true)
            {
                menu.Print(choices);

                bool isMainMenu = choices.Count == 0;

                int choice = menu.GetChoice(isMainMenu);

                if (choice == 0)
                {
                    if (choices.Count > 0)
                    {
                        choices.RemoveAt(choices.Count - 1);
                    }
                    else
                    {
                        Console.WriteLine("You are in the main menu already");
                    }
                }
                else
                {
                    choices.Add(choice);
                }

                Console.Clear();
            }
        }
    }
}
