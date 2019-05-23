using NUnit.Framework;
using Lesson07_03;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TaxShouldCalculate5PercentWhenIncomeIsLess40000()
        {
            //Arange - Mes pasiruosiam

            decimal income = 1000;
            decimal tax = 50;
            decimal calculatedTax = 0;

            //Act


            calculatedTax = Program.Tax
            //Assert

            Assert.Pass();
        }
    }
}