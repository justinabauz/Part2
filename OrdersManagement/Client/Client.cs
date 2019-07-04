using System;

namespace DataBL
{
    public class Client
    {

        public Client()
        {

        }

        public Client(int clientId, string name, string surname, int homeAdressId, int deliveryAdressId)
        {
            ClientID = clientId;
            Name = name;
            Surname = surname;
            HomeAdressId = homeAdressId;
            DeliveryAdressId = deliveryAdressId;

        }
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int HomeAdressId { get; set; }
        public int DeliveryAdressId { get; set; }

    }
}
