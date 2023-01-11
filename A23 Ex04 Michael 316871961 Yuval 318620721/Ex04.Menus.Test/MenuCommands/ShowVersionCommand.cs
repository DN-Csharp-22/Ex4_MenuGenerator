using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionCommand : ICommand
    {
        public string GetCommandHeader()
        {
            return "Show Version";
        }

        public void Run()
        {
            MenuCommands.PrintVersionToConsole();
        }
    }
}
