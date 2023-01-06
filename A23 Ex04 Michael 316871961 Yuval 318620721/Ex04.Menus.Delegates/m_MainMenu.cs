using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class m_MainMenu
    {
        List<MenuItem> MenuItems { get; set; }
        public m_MainMenu(List<MenuItem> menuItems)
        {
            this.MenuItems = menuItems;
        }
        public void Show()
        {

        }
    }
}
