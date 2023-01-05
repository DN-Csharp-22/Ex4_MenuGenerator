using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class ShowTimeCommand : ICommand
    {
        public void Run()
        {
            MenuCommands.PrintCurrentTimeToConsole();
        }
    }
}
