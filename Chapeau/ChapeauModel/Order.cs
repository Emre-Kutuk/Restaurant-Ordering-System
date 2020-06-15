using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        // list of suborder items
        // seperate table for payment

        // here a list of order items
        // class order-item can have a class menu item.
        public int OrderId { get; set; }
        public RestaurantTable Table { get; set; }
        public Employee OrderTakenBy { get; set; }
        public List<OrderItem> OrderItemList { get; set; }
        public bool Ispayed { get; set; }
        public decimal Tip { get; set; }
        public decimal TotalCost { get; set; }
        public string Feedback { get; set; }

        public Order(int orderId, RestaurantTable table, Employee orderTakenBy, List<OrderItem> orderItemList, bool ispayed, decimal tip, decimal totalCost, string feedback)
        {
            OrderId = orderId;
            Table = table;
            OrderTakenBy = orderTakenBy;
            OrderItemList = orderItemList;
            Ispayed = ispayed;
            Tip = tip;
            TotalCost = totalCost;
            Feedback = feedback;
        }

        //Calculates the total price considering amount/count
        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (OrderItem orderItem in OrderItemList)
            {
                totalPrice += orderItem.Count * orderItem.MenuItem.Price;
            }

            return totalPrice;
        }
    }
}
