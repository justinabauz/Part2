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

            AgeClass Asmuo = new AgeClass("Juste", "Bauz", new DateTime(2018, 2, 13));

            int expected = 1;

            int actual = Asmuo.GetAge();

            Assert.AreEqual(expected, actual);
        }
    }
}