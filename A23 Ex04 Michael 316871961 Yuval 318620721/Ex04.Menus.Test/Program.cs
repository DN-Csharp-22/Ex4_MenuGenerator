using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ShowVersionCommand : ICommand
    {
        public void ShowVersion()
        {
            Console.WriteLine("");
        }
    }
}
