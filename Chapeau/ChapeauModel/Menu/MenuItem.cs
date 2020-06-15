using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public int CategorieId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public MenuItem(int itemId, int categorieId, string name, decimal price, int stock)
        {
            ItemId = itemId;
            CategorieId = categorieId;
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
