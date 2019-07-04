using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBL
{
    public class ReportGenerator
    {
        AdressRepository adressRepository = new AdressRepository();
        ClientRepository clientRepository = new ClientRepository();
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
        public void GenerateOrdersReportByStatus(List<Order> ReportOrders, OrderStatus ReportingStatus)
        {
            string OrderTemp = "";
            foreach (Order ReportOrder in ReportOrders)
            {
                if (ReportOrder.Status == ReportingStatus)
                {

                    var client = clientRepository.Retrieve(ReportOrder.ClientId);
                    OrderTemp += "OrderId: " + ReportOrder.OrderId + " ClientId: " + ReportOrder.ClientId + " Client Name: " + client.Name
                        + " Status: " + ReportOrder.Status
                        + Environment.NewLine;
                }
            }
            Console.WriteLine(OrderTemp);
        }

    }
}

