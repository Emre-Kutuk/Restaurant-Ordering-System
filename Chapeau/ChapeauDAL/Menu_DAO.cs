using ChapeauModel;
using ChapeauModel.Menu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class Menu_DAO : Base
    {
        public List<MainMenu> Db_Get_Full_Menu()
        {
            string query = @"
                SELECT * FROM [Menu_Item] 
                    inner join [Menu_Categories] 
                        on [Menu_Item].menu_categorie_id = [Menu_Categories].menu_categorie_id 
                    inner join [Menu] 
                        on [Menu].menu_id = [Menu_Categories].menu_id
                    order by
                        [Menu].menu_id,
                        [Menu_Categories].menu_categorie_id;";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MainMenu> ReadAllMenuItems(DataTable dataTable)
        {
            List<MainMenu> mainMenuList = new List<MainMenu>();
            int menuId = -1;

            foreach (DataRow dr in dataTable.Rows)
            {
                int currentMenuId = (int)dr["menu_id"];

                if (menuId != currentMenuId)
                {
                    MainMenu menu = new MainMenu(
                        currentMenuId,
                        dr["menu_name"].ToString(),
                        (TimeSpan)dr["start_time"],
                        (TimeSpan)dr["end_time"],
                        new List<MenuCategorie>()
                    );

                    menu.MenuCategories = ReadCategorieTables(dataTable, menu);

                    mainMenuList.Add(menu);
                }

                menuId = currentMenuId;
            }
            return mainMenuList;
        }

        private List<MenuCategorie> ReadCategorieTables(DataTable dataTable, MainMenu mainMenu)
        {
            DataView view = new DataView(dataTable);
            view.RowFilter = $"menu_id = {mainMenu.MenuId}";

            List<MenuCategorie> menuCategorieList = new List<MenuCategorie>();
            int categorieId = -1;

            foreach (DataRowView dr in view)
            {
                int currentCategorieId = (int)dr["menu_categorie_id"];

                if (categorieId != currentCategorieId)
                {
                    MenuCategorie categorie = new MenuCategorie(
                        currentCategorieId,
                        (int)dr["menu_id"],
                        dr["categorie_name"].ToString(),
                        (bool)dr["VAT"],
                        new List<MenuItem>()
                    );
                    categorie.MenuItems = ReadMenuItemTables(dataTable, categorie);
                    
                    menuCategorieList.Add(categorie);
                }

                categorieId = currentCategorieId;
            }
            return menuCategorieList;
        }

        private List<MenuItem> ReadMenuItemTables(DataTable dataTable, MenuCategorie menuCategorie)
        {
            DataView view = new DataView(dataTable);
            view.RowFilter = $"menu_categorie_id = {menuCategorie.CategorieId}";

            List<MenuItem> menuItemsList = new List<MenuItem>();

            foreach (DataRowView dr in view)
            {
                MenuItem item = new MenuItem(
                    (int)dr["menu_item_id"],
                    (int)dr["menu_categorie_id"],
                    dr["item_name"].ToString(),
                    (decimal)dr["price"],
                    (int)dr["stock"]
                );

                menuItemsList.Add(item);
            }
            return menuItemsList;
        }

        //changing stock method
        public void ChangeStock(string item_name, int stock)
        {
            // the @ gets the updated version
            string query = "UPDATE Menu_Item SET [stock]=@stock WHERE item_name=@item_name";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[1] = new SqlParameter();
            sqlParameters[0].ParameterName = "stock";
            sqlParameters[0].Value = stock;
            sqlParameters[1].ParameterName = "item_name";
            sqlParameters[1].Value = item_name;
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
