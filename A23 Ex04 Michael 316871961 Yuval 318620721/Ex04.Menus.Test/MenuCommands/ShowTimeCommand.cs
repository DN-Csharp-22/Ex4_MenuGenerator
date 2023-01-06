using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class ShowTimeCommand : ICommand
    {
        public string GetCommandHeader()
        {
            return "Show Time";
        }

        public void Run()
        {
            MenuCommands.PrintCurrentTimeToConsole();
        }
    }
}
