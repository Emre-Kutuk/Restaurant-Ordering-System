using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel.Menu
{
    public class MenuCategorie
    {
        public int CategorieId { get; set; }
        public int MainMenuId { get; set; }
        public string CategorieName { get; set; }
        public bool VAT { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public MenuCategorie(int categorieId, int mainMenuId, string categorieName, bool vat, List<MenuItem> menuItems)
        {
            CategorieId = categorieId;
            MainMenuId = mainMenuId;
            CategorieName = categorieName;
            VAT = vat;
            MenuItems = menuItems;
        }
    }
}
