using NUnit.Framework;
using CRM.BL;

namespace CRM.BL.Test3
{
    public class Tests
    {
        /*[Test]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggings";

            string expected = "Baggings, Bilbo";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
        */
        [Test]
        public void FullNameLastName()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FullNameFirstName()
        {
            Customer customer = new Customer
            {
                LastName = "Bilbo"
            };
            string expected = "Bilbo";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidateTestTrue()
        {
            Customer customer = new Customer
            {
                LastName = "Labas",
                EmailAdress = "Labas rytas"
            };
            bool expected = true;
            bool actual = customer.Validate();
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void ValidateTestFalse()
        {
            Customer customer = new Customer
            {
                LastName = "Labas",
            };
            bool expected = false;
            bool actual = customer.Validate();
            Assert.AreEqual(expected, actual);

        }


    }
}

