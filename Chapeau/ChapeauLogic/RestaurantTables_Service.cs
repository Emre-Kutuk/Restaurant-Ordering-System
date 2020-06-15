using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;

namespace ChapeauLogic
{
    public class RestaurantTables_Service
    {
        private RestaurantTables_DAO restaurantTables_db = new RestaurantTables_DAO();
        private List<RestaurantTable> restaurantTable;
        public List<RestaurantTable> GetRestaurantTables()
        {
            try
            {
                restaurantTable = restaurantTables_db.Db_Get_All_RestaurantTables();
                return restaurantTable;
            }
            catch (Exception e)
            {
                throw new Exception("Chapeau application couldn't connect to the database. Therefore we can't retrieve the restaurant tables data.");
            }
        }

        public void OccupyTable(int tableNumber)
        {
            try
            {
                restaurantTables_db.Db_Occupy_RestaurantTables(tableNumber);
            }
            catch (Exception e)
            {
                throw new Exception("Chapeau application couldn't connect to the database. Therefore we can't occupy the restaurant table.");
            }
        }
    }
}
