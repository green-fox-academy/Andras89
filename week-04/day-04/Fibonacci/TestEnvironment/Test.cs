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

        [TestCase('0')]
        public void WhatsIsIndexZero(char index)
        {
            Assert.AreEqual(0, fibo.FibonacciMaker(index));
        }

        [TestCase('1')]
        public void WhatsIsIndexOne(char index)
        {
            Assert.AreEqual(1, fibo.FibonacciMaker(index));
        }

        [TestCase('2')]
        public void WhatsIsIndexTwo(char index)
        {
            Assert.AreEqual(1, fibo.FibonacciMaker(index));
        }

        [TestCase("-1")]
        public void WhatsIsIndexMinusOne(char index)
        {
            Assert.AreEqual(0, fibo.FibonacciMaker(index));
        }

        [TestCase('a')]
        public void WhatsIsIndexA(char index)
        {
            Assert.Catch<ArgumentException>(() => fibo.FibonacciMaker(index));
        }
    }
}
