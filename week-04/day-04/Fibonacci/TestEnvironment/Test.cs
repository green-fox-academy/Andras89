using Fibonacci;
using NUnit.Framework;
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
        Fibonacciziator fibo;

        [SetUp]
        public void SetUp()
        {
            fibo = new Fibonacciziator();
        }

        [TearDown]
        public void TearDown()
        {
            fibo = null;
        }

        [TestCase("0")]
        [TestCase(0)]
        [TestCase('0')]
        public void WhatsIsIndexZero(object index)
        {
            Assert.AreEqual(0, fibo.FibonacciMaker(index));
        }

        [TestCase("1")]
        [TestCase(1)]
        [TestCase('1')]
        public void WhatsIsIndexOne(object index)
        {
            Assert.AreEqual(1, fibo.FibonacciMaker(index));
        }

        [TestCase("2")]
        [TestCase(2)]
        [TestCase('2')]
        public void WhatsIsIndexTwo(object index)
        {
            Assert.AreEqual(1, fibo.FibonacciMaker(index));
        }

        [TestCase("3")]
        [TestCase(3)]
        [TestCase('3')]
        public void WhatsIsIndexThree(object index)
        {
            Assert.AreEqual(2, fibo.FibonacciMaker(index));
        }

        [TestCase("-1")]
        [TestCase(-156565)]
        public void WhatsIsIndexMinusOne(object index)
        {
            Assert.AreEqual(0, fibo.FibonacciMaker(index));
        }

        [TestCase('a')]
        [TestCase("dhghFGHfbgf")]
        [TestCase(0.453456)]
        [TestCase(0.4545f)]
        [TestCase("0.4343")]
        public void WhatsIsIndexA(object index)
        {
            Assert.Catch<ArgumentException>(() => fibo.FibonacciMaker(index));
        }
    }
}
