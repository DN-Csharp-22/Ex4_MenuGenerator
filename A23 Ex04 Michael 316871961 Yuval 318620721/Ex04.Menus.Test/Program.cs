using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationManager applicationManager = new ApplicationManager();

            applicationManager.StartApplicationUsingInterfaces();

            applicationManager.StartApplicationUsingDelegates();
        }
    }

    public class ApplicationManager
    {
        public ApplicationManager() { }
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
                        Commands = new Interfaces.ICommand[]
                        {
                            new ShowVersionCommand(),
                            new CountUppercaseCommand()
                        }
                    },
                    new Interfaces.MenuItem()
                    {
                        Header = "Show Date/Time",
                        menuOptions = new List<Interfaces.MenuItem>(),
                        Commands = new Interfaces.ICommand[]
                        {
                            new ShowDateCommand(),
                            new ShowTimeCommand()
                        }
                    }
                },
                Commands = new Interfaces.ICommand[0]
            };

            Interfaces.m_MainMenu applicationMenu = new Interfaces.m_MainMenu(menu);

            applicationMenu.Show();
        }

        public void StartApplicationUsingDelegates()
        {

        }
    }
}
