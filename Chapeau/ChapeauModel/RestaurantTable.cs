using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class RestaurantTable
    {
        // also occupied
        public int TableId { get; set; }
        public bool IsOccupied { get; set; }
        public int NumberOfSeats { get; set; }

        public RestaurantTable(int tableId, bool isOccupied, int numberOfSeats)
        {
            TableId = tableId;
            IsOccupied = isOccupied;
            NumberOfSeats = numberOfSeats;
        }
    }
}
