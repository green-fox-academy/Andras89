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
        public void IfCardIsQueenReturn12(string input)
        {
            int output = pokerTesting.FigureValue(input);
            Assert.AreEqual(12, output);
        }

        [TestCase("K")]
        public void IfCardIsKingReturn13(string input)
        {
            int output = pokerTesting.FigureValue(input);
            Assert.AreEqual(13, output);
        }

        [TestCase("A")]
        public void IfCardIsAceReturn14(string input)
        {
            int output = pokerTesting.FigureValue(input);
            Assert.AreEqual(14, output);
        }

        [TestCase("2C")]
        public void IfCardIs2CReturn2(string input)
        {
            int output = pokerTesting.CardValue(input);
            Assert.AreEqual(2, output);
        }

        [TestCase(new object[]{ new string[] { "2C", "2D", "2S", "2H" } })]
        public void IfCardIs2ColorReturn2Array(string[] input)
        {
            List<int> output = new List<int>();
            input.ToList().ForEach(x => output.Add(pokerTesting.CardValue(x)));

            Assert.AreEqual(new int[] { 2, 2, 2, 2}, output.ToArray());
        }

        [TestCase(new object[] { new string[] { "3C", "3D", "3S", "3H" } })]
        public void IfCardIs3ColorReturn3Array(string[] input)
        {
            List<int> output = new List<int>();
            input.ToList().ForEach(x => output.Add(pokerTesting.CardValue(x)));

            Assert.AreEqual(new int[] { 3, 3, 3, 3 }, output.ToArray());
        }

        [TestCase(new object[] { new string[] { "QC", "QD", "QS", "QH" } })]
        public void IfCardIsQueenColorReturn12Array(string[] input)
        {
            List<int> output = new List<int>();
            input.ToList().ForEach(x => output.Add(pokerTesting.CardValue(x)));

            Assert.AreEqual(new int[] { 12, 12, 12, 12 }, output.ToArray());
        }
    }
}
