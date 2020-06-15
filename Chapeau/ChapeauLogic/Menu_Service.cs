using ChapeauDAL;
using ChapeauModel;
using ChapeauModel.Menu;
using System;
using System.Collections.Generic;

namespace ChapeauLogic
{
    public class Menu_Service
    {
        private Menu_DAO Menu_db = new Menu_DAO();
        private List<MainMenu> menus;
        public List<MainMenu> GetFullMenu()
        {
            try
            {
                menus = Menu_db.Db_Get_Full_Menu();
                return menus;
            }
            catch (Exception e)
            {
                // log error message
                throw new Exception(e.Message);
            }
        }
        public void ChangeStock(string name, int stock)
        {
            try
            {
                // for changing an items stock
                Menu_db.ChangeStock(name, stock);
            }
            catch (Exception e)
            {
                throw new Exception("could not change stock");
            }
        }
    }
}
