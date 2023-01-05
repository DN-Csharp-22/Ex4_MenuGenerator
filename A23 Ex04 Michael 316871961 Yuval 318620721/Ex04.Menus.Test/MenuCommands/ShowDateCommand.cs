using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class ShowDateCommand : ICommand
    {
        public void Run()
        {
            MenuCommands.PrintCurrentDateToConsole();
        }
    }
}
