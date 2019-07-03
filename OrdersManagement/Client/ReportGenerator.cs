using System;
using System.Collections.Generic;


namespace DataBL
{
    public class ReportGenerator
    {
        AdressRepository adressRepository = new AdressRepository();
        private ClientRepository _clientRepository;
        public ReportGenerator(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public string GenerateClientsReport()
        {
            List<Client> clients = _clientRepository.Retrieve();
            string clientTemp = "";

           
            foreach (var oneClient in clients)
           {
                var clientHomeAdress = adressRepository.Retrieve(oneClient.HomeAdressId);
                var clientDeliveryAdress = adressRepository.Retrieve(oneClient.DeliveryAdressId);

                clientTemp += "ID: " + oneClient.ClientID + " Name: " + oneClient.Name + " Surname: " + oneClient.Surname
                     + " Home Adress City" + clientHomeAdress.City + " Home Adress Street" + clientHomeAdress.Street + " Delivery Adress City: " 
                     + clientDeliveryAdress.City + " Delivery Adress Street:" + clientDeliveryAdress.Street + Environment.NewLine;
            }
            return clientTemp;
        }
        public string GenerateUnpaidOrders(List<Order> orders)
        { 
            foreach (var order in orders)
            { 
            
            
            }

            return "";
        }


    }
}

//Inventory inventory = inventoryRepository.Retrieve(item.ItemId);
//Console.WriteLine("Index: {1}, Items Name: {0}", inventory.ItemName, itemsindex);
//                            itemsindex = itemsindex + 1;