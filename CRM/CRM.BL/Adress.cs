using System;
namespace CRM.BL
{
    public class Adress
    {
        public Adress(int adressId)
        {
            AdressId = adressId;

        }

        public int AdressId { get; private set; }
        public int AdressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(PostalCode))
            {
                isValid = false;

            }

            return isValid;
        }
    }
}