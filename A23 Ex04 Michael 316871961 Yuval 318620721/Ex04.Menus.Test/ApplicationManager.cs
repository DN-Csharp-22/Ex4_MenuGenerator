using System;
using System.Collections.Generic;

namespace Ex04.Menus.Test
{
    public class ApplicationManager
    {
        public ApplicationManager() 
        {
        }

        public void Start()
        {
            StartApplicationUsingInterfaces();

            Console.Clear();

            StartApplicationUsingDelegates();
        }

        public void StartApplicationUsingInterfaces()
        {
            Interfaces.MenuItem menu = new Interfaces.MenuItem()
            {
                Header = "Interfaces Main Menu",
                menuOptions = new List<Interfaces.MenuItem>()
                {
                    new Interfaces.MenuItem()
                    {
                        Header = "Version and Uppercase",
                        menuOptions = new List<Interfaces.MenuItem>(),
                        commands = new Interfaces.ICommand[]
                        {
                            new ShowVersionCommand(),
                            new CountUppercaseCommand()
                        }
                    },
                    new Interfaces.MenuItem()
                    {
                        Header = "Show Date/Time",
                        menuOptions = new List<Interfaces.MenuItem>(),
                        commands = new Interfaces.ICommand[]
                        {
                            new ShowDateCommand(),
                            new ShowTimeCommand()
                        }
                    }
                },
                commands = new Interfaces.ICommand[0]
            };

            Interfaces.m_MainMenu applicationMenu = new Interfaces.m_MainMenu(menu);

            applicationMenu.Show();
        }

        public void StartApplicationUsingDelegates()
        {
            Delegates.MenuItem menu = new Delegates.MenuItem()
            {
                Header = "Delegates Main Menu",
                menuOptions = new List<Delegates.MenuItem>()
                {
                    new Delegates.MenuItem()
                    {
                        Header = "Version and Uppercase",
                        menuOptions = new List<Delegates.MenuItem>(),
                        commands = new Tuple<string, Delegates.menuCommandDelegate>[2]
                        {
                            new Tuple<string, Delegates.menuCommandDelegate>("Show Version", MenuCommands.PrintVersionToConsole),
                            new Tuple<string, Delegates.menuCommandDelegate>("Count Uppercase", MenuCommands.CountUppercaseLettersFromInput)
                        }
                    },
                    new Delegates.MenuItem()
                    {
                        Header = "Show Date/Time",
                        menuOptions = new List<Delegates.MenuItem>(),
                        commands = new Tuple<string, Delegates.menuCommandDelegate>[2]
                        {
                            new Tuple<string, Delegates.menuCommandDelegate>("Show Date", MenuCommands.PrintCurrentDateToConsole),
                            new Tuple<string, Delegates.menuCommandDelegate>("Show Time", MenuCommands.PrintCurrentTimeToConsole)
                        }
                    }
                },
                commands = new Tuple<string, Delegates.menuCommandDelegate>[0]
            };

            Delegates.m_MainMenu applicationMenu = new Delegates.m_MainMenu(menu);

            applicationMenu.Show();
        }
    }
}
