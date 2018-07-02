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
            int output = pokerTesting.FigureValue(input);
            Assert.AreEqual(2, output);
        }

        [TestCase("3")]
        public void IfCardIsThreeReturnThree(string input)
        {
            int output = pokerTesting.FigureValue(input);
            Assert.AreEqual(3, output);
        }

        [TestCase("J")]
        public void IfCardIsJackReturnEleven(string input)
        {
            int output = pokerTesting.FigureValue(input);
            Assert.AreEqual(11, output);
        }

        [TestCase("Q")]
        public void IfCardIsQueenReturnQueen(string input)
        {
            int output = pokerTesting.FigureValue(input);
            Assert.AreEqual(12, output);
        }

        [TestCase("K")]
        public void IfCardIsKingReturnKing(string input)
        {
            int output = pokerTesting.FigureValue(input);
            Assert.AreEqual(13, output);
        }
    }
}
