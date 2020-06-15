using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int Order_itemid { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Count { get; set; }
        public string Comment { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime Time { get; set; }
        public int Table { get; set; } // used for getting the table no (only for bar and kitchen)

        public OrderItem(MenuItem menuItem, int count, string comment, OrderStatus status, DateTime time, int orderid)
        {
            MenuItem = menuItem;
            Count = count;
            Comment = comment;
            Status = status;
            Time = time;
            Order_itemid = orderid;
        }
    }
}
