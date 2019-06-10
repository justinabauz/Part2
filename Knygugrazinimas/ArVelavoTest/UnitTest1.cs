using NUnit.Framework;
using System;
using BookBL;

namespace Tests
{
        public class UnitTest1
        {
            [Test]
            public void ArVelavoTest()
            {

                BibliotekosKnyga knyga = new BibliotekosKnyga("15", "knygute", 15, 1);

                bool expected = true;
                knyga.PaemimoData = new DateTime(2019, 06, 01);

                bool actual = knyga.ArVelavo();

                Assert.AreEqual(expected, actual);
            }
        }
}