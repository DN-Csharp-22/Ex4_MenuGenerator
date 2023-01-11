using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountUppercaseCommand : ICommand
    {
        public string GetCommandHeader()
        {
            return "Count Uppercase";
        }

        public void Run()
        {
            MenuCommands.CountUppercaseLettersFromInput();
        }
    }
}
