using System;

namespace CRM.BL
{
    public class Customer
    {
        public int CustomerID{ get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName) &&  !string.IsNullOrWhiteSpace(FirstName))
                {
                    return FirstName;
                }
                else if (string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName))
                {
                    return LastName;
                }
                else if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName))
                {
                    return LastName + ", " + FirstName;
                }
                else
                {
                    return "";
                }
            }

        }
        public string EmailAdress { get; set; }
        public string HomeAdress { get; set; }
        public string WorkAdress { get; set; }


        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            
            }
            if (string.IsNullOrWhiteSpace(EmailAdress))
            {
                isValid = false;

            }

            return isValid;

        }

        public Customer()
        {

        }
        public Customer(int customerID)
        {
            CustomerID = customerID;
        }

    }
}
