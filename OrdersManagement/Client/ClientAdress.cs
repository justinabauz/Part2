using System;
namespace DataBL
{
    public class ClientAdress
    {
        public ClientAdress()
        {

        }

        public ClientAdress(int adressId, string city, string street, int zipcode)
        {
            AdressId = adressId;
            City = city;
            Street = street;
            Zipcode = zipcode;

        }
        public int AdressId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Zipcode { get; set; }
    }
}
