using NUnit.Framework;
using VardasPavarde;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAgeTest()
        {
            AgeClass Age = new AgeClass();
            Age.GimimoMetai = DateTime(2018, 2, 13);

            int expected = 1;

            int actual = Age.GetAge();

            Assert.AreEqual(expected, actual);
        }
    }
}