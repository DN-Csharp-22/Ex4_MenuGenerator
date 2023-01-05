using System;
using System.Linq;

namespace Ex04.Menus.Test
{
    internal static class MenuCommands
    {
        public static void CountUppercaseLettersFromInput()
        {
            Console.WriteLine("Please insert a text");

            string input = Console.ReadLine();

            int amountOfUppercaseLetters = input.Where(character => char.IsUpper(character)).ToList().Count;

            Console.WriteLine(string.Format("The amount of uppercase letters in the text is : {0}", amountOfUppercaseLetters));
        }

        public static void PrintCurrentDateToConsole()
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.ToShortDateString());
        }

        public static void PrintCurrentTimeToConsole()
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.ToShortTimeString());
        }

        public static void PrintVersionToConsole()
        {
            Console.WriteLine("Version:23.1.4.8859");
        }
    }
}
