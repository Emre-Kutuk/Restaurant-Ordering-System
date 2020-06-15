using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel.Menu
{
    public class MainMenu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public TimeSpan MenuAvailableStart { get; set; }
        public TimeSpan MenuAvailableEnd { get; set; }
        public List<MenuCategorie> MenuCategories { get; set; }
        public MainMenu(int menuId,string menuName, TimeSpan menuAvailableStart, TimeSpan menuAvailableEnd, List<MenuCategorie> menuCategories)
        {
            MenuId = menuId;
            MenuName = menuName;
            MenuAvailableStart = menuAvailableStart;
            MenuAvailableEnd = menuAvailableEnd;
            MenuCategories = menuCategories;
        }
    }
}
