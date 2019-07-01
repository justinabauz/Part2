using System;
using System.Collections.Generic;
using System.Linq;


namespace DataBL
{
    public class Order
    {
        private List<OrderItem> orderItems = new List<OrderItem>();

        public Order()
        {
        }

        public Order(int clientId, OrderStatus status, DateTime date)
        {
            ClientId = clientId;
            Status = status;
            Date = date;
        }

        public int ClientId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItem> OrderItems { get { return orderItems; } }

        public void AddnewItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

        public void DeleteItem(int index)
        {
            orderItems.RemoveAt(index);
        }
   }
}
