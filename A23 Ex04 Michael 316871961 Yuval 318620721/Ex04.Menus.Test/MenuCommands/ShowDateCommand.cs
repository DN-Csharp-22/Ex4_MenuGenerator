using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateCommand : ICommand
    {
        public string GetCommandHeader()
        {
            return "Show Date";
        }

        public void Run()
        {
            MenuCommands.PrintCurrentDateToConsole();
        }
    } 
}
