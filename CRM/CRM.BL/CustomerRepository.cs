using System;
namespace CRM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerID)
        {
            Customer customer = new Customer(customerID);

            if (customerID ==1)
            {
                customer.EmailAdress = "fag@gmail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
    }
}
