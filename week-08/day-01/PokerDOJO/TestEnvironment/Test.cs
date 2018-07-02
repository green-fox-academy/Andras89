using NUnit.Framework;
using PokerDOJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class Test
    {
        Poker pokerTesting;

        [SetUp]
        public void SetUp()
        {
            pokerTesting = new Poker();
        }

        [TestCase("2")]
        public void IfCardIsTwoReturnTwo(string input)
        {
            int output = pokerTesting.CardValue(input);
            Assert.AreEqual(2, output);
        }
    }
}
