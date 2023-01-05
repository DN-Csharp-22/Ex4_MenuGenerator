using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Menu
    {
        public Menu(List<MenuItem> menuItems)
        {
            this.Items = menuItems;

            this.Items.Prepend(
                new MenuItem() 
                { 
                }
            );//Back/Exit
        }

        public string Header { get; set; }

        public List<MenuItem> Items { get; set; }

        public string Message { get; set; }
    }
}
