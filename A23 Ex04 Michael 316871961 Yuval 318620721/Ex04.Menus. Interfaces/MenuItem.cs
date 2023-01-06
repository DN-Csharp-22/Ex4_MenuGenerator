using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public string Header { get; set; }

        public List<string> menuOptions { get; set; }

        public string Message { get; set; }
    }
}
