using Ex04.Menus.Interfaces;
using System;
using System.Linq;

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
