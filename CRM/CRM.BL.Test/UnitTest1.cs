using System;
using Xunit;
using CRM.BL;

namespace CRM.BL.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggings, Bilbao";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);

        }
    }
}
