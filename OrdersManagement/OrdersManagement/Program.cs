using System;
using DataBL;
using System.Collections.Generic;

namespace OrdersManagement
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ClientRepository clientRepository = new ClientRepository();
            InventoryRepository inventoryRepository = new InventoryRepository();
            AdressRepository adressRepository = new AdressRepository();
           
            int MainAction = -1;

            while (MainAction != 0)
            {
                Console.WriteLine("Do you want to modify: client data [1] - Inventory data [2] - Order data [3] " +
                    "- Generate reports [4] - Exit [0]");
                MainAction = Convert.ToInt32(Console.ReadLine());
                if (MainAction == 1)
                {
                    Console.WriteLine("Do you want to add or delete client? [1] - Add new client, [2] - Delete client, " +
                        "[3] - No changes in client's data");
                    int changeClientsData = Convert.ToInt32(Console.ReadLine());
                    int clientItemIndex = 0;

                    if (changeClientsData == 1)
                    {

                        Console.WriteLine("Please enter clients ID");
                        int newClientsID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter clients Name");
                        string newClientsName = Console.ReadLine();
                        Console.WriteLine("Please enter clients Surname");
                        string newClientsSurname = Console.ReadLine();
                        Console.WriteLine("How do you want to enter Home adress? [1] " +
                            "- Select adress ID from the list below, [2] - Add new adress");
                        foreach (var adress in adressRepository.Retrieve())
                        {
                            Console.WriteLine("Adress ID - {0}, City - {1}, Street - {2}", adress.AdressId, adress.City,
                                adress.Street);
                        }

                        int adressSelectionOption = Convert.ToInt32(Console.ReadLine());
                        int homeAdressID = 0;
                        if (adressSelectionOption == 1)
                        {
                            Console.WriteLine("Please enter home adress id from the list");
                            homeAdressID = Convert.ToInt32(Console.ReadLine());
                        }

                        else if (adressSelectionOption == 2)

                        {
                            Console.WriteLine("Please enter new adress Id");
                            homeAdressID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Please enter new adress City");
                            string newadressCity = Console.ReadLine();

                            Console.WriteLine("Please enter new adress Street");
                            string newadressStreet = Console.ReadLine();

                            Console.WriteLine("Please enter new adress ZipCode");
                            int newadressZipCode = Convert.ToInt32(Console.ReadLine());

                            adressRepository.AddnewAdress(new ClientAdress(homeAdressID, newadressCity, newadressStreet,
                                newadressZipCode));

                            foreach (var adress in adressRepository.Retrieve())
                            {
                                Console.WriteLine("Adress ID - {0}, City - {1}, Street - {2}", adress.AdressId, adress.City,
                                    adress.Street);
                            }

                        }


                        Console.WriteLine("Please enter delivery adress id");
                        int deliveryAdressId = Convert.ToInt32(Console.ReadLine());


                        clientRepository.AddNewItem(new Client(newClientsID, newClientsName, newClientsSurname, homeAdressID, deliveryAdressId));


                        foreach (var cl in clientRepository.Retrieve())
                        {
                            Console.WriteLine("Client {0}", cl.ClientID);
                        }

                    }

                    else if (changeClientsData == 2)
                    {

                        Console.WriteLine("Please select number of the client you want to delete from the list");
                        foreach (var cl in clientRepository.Retrieve())
                        {

                            Console.WriteLine("Item index: {1}, Client {0}", cl.ClientID, clientItemIndex);
                            clientItemIndex = clientItemIndex + 1;
                        }

                        int clientItemIndexToDelete = Convert.ToInt32(Console.ReadLine());

                        clientRepository.DeleteItem(clientItemIndexToDelete);

                        foreach (var cl in clientRepository.Retrieve())
                        {
                            Console.WriteLine("Client {0}", cl.ClientID);
                        }

                    }
                }
                else if (MainAction == 2)
                {
                    Console.WriteLine("Do you want to add or delete inventory items? [1] - Add new item, [2] - Delete item, " +
                        "[3] - No changes in inventory data");

                    int changeInventoryData = Convert.ToInt32(Console.ReadLine());
                    int inventoryItemIndex = 0;

                    if (changeInventoryData == 1)
                    {
                        Console.WriteLine("Please enter item ID");
                        int newItemID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item Name");
                        string newItemsName = Console.ReadLine();
                        Console.WriteLine("Please enter item price");
                        decimal newItemPrice = Convert.ToDecimal(Console.ReadLine());
                        inventoryRepository.AddnewInventory(new Inventory(newItemID, newItemsName, newItemPrice));

                        foreach (var inv in inventoryRepository.Retrieve())
                        {
                            Console.WriteLine("Inventory item {0}", inv.ItemId);
                        }
                    }

                    else if (changeInventoryData == 2)
                    {

                        Console.WriteLine("Please enter inventory index to delete inventory item from the list below");
                        foreach (var inv in inventoryRepository.Retrieve())
                        {
                            Console.WriteLine("Item index: {1}, Inventory Item {0}", inv.ItemId, inventoryItemIndex);
                            inventoryItemIndex = inventoryItemIndex + 1;
                        }
                        int inventoryItemIndexToDelete = Convert.ToInt32(Console.ReadLine());

                        inventoryRepository.DeleteItem(inventoryItemIndexToDelete);

                        foreach (var inv in inventoryRepository.Retrieve())
                        {
                            Console.WriteLine("Inventory item {0}", inv.ItemId);
                        }

                    }
                }
                else if (MainAction == 3)
                {
                    Console.WriteLine("Do you want to add a new order? [1] - Yes, [2] - Modify existing order, [3] - No");

                    int addNewOrder = Convert.ToInt32(Console.ReadLine());

                    if (addNewOrder == 1)
                    {
                        Order order = new Order();
                        order.Status = OrderStatus.Created;
                        order.Date = DateTime.Now;

                        Console.WriteLine("Please enter Client's ID from the list below:");
                        foreach (var cl in clientRepository.Retrieve())
                        {
                            Console.WriteLine("Client {0}", cl.ClientID);
                        }
                        int clientsId = Convert.ToInt32(Console.ReadLine());

                        //Patikrint ar toks ID egzistuoja!

                        order.ClientId = clientsId;

                        bool addInventory = true;
                        while (addInventory == true)
                        {
                            Console.WriteLine("Do you want to add new item to order? [1] - Add new item, [2] - Delete item from" +
                                "order, [3] - Finish order");
                            int addItemToOrder = Convert.ToInt32(Console.ReadLine());
                            if (addItemToOrder == 1)
                            {

                                OrderItem orderItem = new OrderItem();

                                Console.WriteLine("Please select Item's Id from the list below:");
                                foreach (var inv in inventoryRepository.Retrieve())
                                {
                                    Console.WriteLine("Inventory item - {0}, Name - {1}, Price - {2}", inv.ItemId, inv.ItemName, inv.ItemPrice);
                                }


                                orderItem.ItemId = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Please add quntity number:");

                                orderItem.Quantity = Convert.ToInt32(Console.ReadLine());


                                Inventory inventory = inventoryRepository.Retrieve(orderItem.ItemId);
                                orderItem.Price = inventory.ItemPrice;

                                order.AddnewItem(orderItem);

                            }
                            else if (addItemToOrder == 2)
                            {
                                int itemsindex = 0;
                                //order.OrderItems;
                                Console.WriteLine("Please neter index from the list of item you want to delete?:");
                                foreach (var item in order.OrderItems)
                                {
                                    Inventory inventory = inventoryRepository.Retrieve(item.ItemId);
                                    Console.WriteLine("Index: {1}, Items Name: {0}", inventory.ItemName, itemsindex);
                                    itemsindex = itemsindex + 1;
                                }

                                int itemsindexToDelete = Convert.ToInt32(Console.ReadLine());

                                order.DeleteItem(itemsindexToDelete);
                            }
                            else
                            {
                                addInventory = false;
                            }
                        }

                    }
                    else if (addNewOrder == 2)
                    {
                        Console.WriteLine("Please select Order ID from the list below:");
                        foreach (var cl in clientRepository.Retrieve())
                        {
                            Console.WriteLine("Client {0}", cl.ClientID);
                        }
                        int clientsId = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (MainAction == 4)
                {
                    Console.WriteLine("Do you want to generate all clients report? [1] - Yes, [2] - No");

                    int generateClientsReport = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Do you want to generate unpaid orders report? [1] - Yes, [2] - No");

                    int unpaidOrdersReport = Convert.ToInt32(Console.ReadLine());
                }
                else if (MainAction == 0)
                {
                    Console.WriteLine("Exiting the system....");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Undefined input. Please select values from {0, 1, 2, 3, 4}");
                }
            }

        }
    }
}
