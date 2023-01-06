﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class m_MainMenu
    {
        MenuItem menu { get; set; }

        List<int> choiceHistory { get; set; }

        public m_MainMenu(MenuItem menuItem)
        {
            this.menu = menuItem;
            this.choiceHistory = new List<int>();
        }

        public void Show()
        {
            while (true)
            {
                menu.Print(choiceHistory, true);

                int choice = menu.GetChoice(choiceHistory, out ICommand command);

                if (choice > 0)
                {
                    if (command != null)
                    {
                        command.Run();
                        Console.ReadKey();
                    }
                    else
                    {
                        choiceHistory.Add(choice);
                    }
                }
                else if (choice == 0)
                {
                    if (choiceHistory.Count == 0) //Exit
                    {
                        break;
                    }
                    else
                    {
                        choiceHistory.RemoveAt(choiceHistory.Count - 1);
                    }
                }

                Console.Clear();
            }
        }
    }
}
