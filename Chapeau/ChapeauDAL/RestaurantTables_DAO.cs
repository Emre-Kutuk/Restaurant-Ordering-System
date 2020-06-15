using ChapeauModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class RestaurantTables_DAO : Base
    {
        public List<RestaurantTable> Db_Get_All_RestaurantTables()
        {
            string query = "SELECT * FROM Restaurant_Table";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<RestaurantTable> ReadTables(DataTable dataTable)
        {
            List<RestaurantTable> restaurantTablesList = new List<RestaurantTable>();

            foreach (DataRow dr in dataTable.Rows)
            {
                RestaurantTable restaurantTables = new RestaurantTable(
                    (int)dr["table_number"],
                    (bool)dr["is_occupied"],
                    (int)dr["number_of_seats"]
                );

                restaurantTablesList.Add(restaurantTables);
            }
            return restaurantTablesList;
        }

        public void Db_Occupy_RestaurantTables(int tableNumber)
        {
            string query = "UPDATE Restaurant_Table SET [is_occupied] = 1 WHERE table_number = @table_number";
            SqlParameter[] sqlParameters = new SqlParameter[1]{
                new SqlParameter("@table_number", tableNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
