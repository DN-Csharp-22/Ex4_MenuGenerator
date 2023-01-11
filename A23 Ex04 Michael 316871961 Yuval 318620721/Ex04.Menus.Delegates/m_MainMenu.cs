using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class m_MainMenu
    {
        private MenuItem menu { get; set; }

        private List<int> choiceHistory { get; set; }

        public m_MainMenu(MenuItem menuItem)
        {
            this.menu = menuItem;
            this.choiceHistory = new List<int>();
        }

        public void Show()
        {
            while (true)
            {
                menu.print(choiceHistory, true);

                int choice = menu.GetChoice(choiceHistory, out menuCommandDelegate command);

                if (choice > 0)
                {
                    if (command != null)
                    {
                        command();
                        Console.ReadKey();
                    }
                    else
                    {
                        choiceHistory.Add(choice);
                    }
                }
                else if (choice == 0)
                {
                    ////Exit
                    if (choiceHistory.Count == 0)
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
