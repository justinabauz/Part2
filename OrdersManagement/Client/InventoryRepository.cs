using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBL
{
    public class InventoryRepository
    {
        private List<Inventory> items = new List<Inventory>();
        public List<Inventory> Retrieve()
        {
            return items;
        }
        public Inventory Retrieve(int itemId)
        {
            return items.Where(x => x.ItemId == itemId).FirstOrDefault();
        }
        public InventoryRepository()
        {
            items.Add(new Inventory(1, "Knyga", 23));
            items.Add(new Inventory(2, "Kompiuteris", 2000));
            items.Add(new Inventory(3, "Laikrodis", 700));
            items.Add(new Inventory(4, "Fotoapratas", 1113));
            items.Add(new Inventory(5, "Knyga", 83));
        }

        public void AddnewInventory(Inventory inventory)
        {
            items.Add(inventory);
        }

        public void DeleteItem(int index)
        {
            items.RemoveAt(index);
        }
    }
}
