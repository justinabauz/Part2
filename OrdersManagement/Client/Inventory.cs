using System;
namespace DataBL
{
    public class Inventory
    {
        public Inventory()
        {

        }

        public Inventory(int itemId, string itemName, decimal itemPrice)
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemPrice = itemPrice;

        }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
