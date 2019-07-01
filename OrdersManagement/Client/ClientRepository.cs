using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBL
{
    public class ClientRepository
    {
            private List<Client> clients = new List<Client>();
   

        public List<Client> Retrieve()
            {
                return clients;
            }

            public Client Retrieve(int clientId)
            {
                return clients.Where(x => x.ClientID == clientId).FirstOrDefault();
            }

            public ClientRepository()
            {
                clients.Add(new Client(1, "Jonas", "Jonaitis", 2, 3));
                clients.Add(new Client(2, "Petras", "Petraitis", 1, 4));
                clients.Add(new Client(3, "Juozas", "Juozaitis", 2, 3));
                clients.Add(new Client(4, "Saulius", "Saulaitis", 1, 5));

            }

        public void AddNewItem(Client client)
            {
                clients.Add(client);
            }

            public void DeleteItem(int index)
            {
                clients.RemoveAt(index);
            }
    }
}
