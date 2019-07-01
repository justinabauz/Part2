using System;
using System.Collections.Generic;
using System.Linq;


namespace DataBL
{
    public class AdressRepository
    {
        private List<ClientAdress> adress = new List<ClientAdress>();

        public List<ClientAdress> Retrieve()
        {
            return adress;
        }
        public ClientAdress Retrieve(int adressId)
        {
            return adress.Where(x => x.AdressId == adressId).FirstOrDefault();
        }
        public AdressRepository()
        {
            adress.Add(new ClientAdress(1, "Vilnius", "Basanaviciaus", 2324));
            adress.Add(new ClientAdress(2, "Kaunas", "Vilniaus", 564856));
            adress.Add(new ClientAdress(3, "Druskininkai", "Vytauto", 5674));
            adress.Add(new ClientAdress(4, "Palanga", "Basanaviciaus", 987));
            adress.Add(new ClientAdress(5, "Vilnius", "Linkmenu", 1234567));

        }

        public void AddnewAdress(ClientAdress newAdress)
        {
            adress.Add(newAdress);
        }
    }
}
