using System;
using System.Collections.Generic;

namespace DataBL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int itemId, decimal price, int quantity)
        {
            ItemId = itemId;
            Price = price;
            Quantity = quantity;

        }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
