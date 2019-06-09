using NUnit.Framework;
using System;
using VardasPavarde;


namespace Tests
{
    public class UnitTest1
    {
        [Test]
        public void GetAgeTest()
        {
            DateTime date = new DateTime(2018, 2, 13);

            AgeClass Asmuo = new AgeClass("Juste", "Bauz", date);

            int expected = 1;

            int actual = Asmuo.GetAge();

            Assert.AreEqual(expected, actual);
        }
    }
}