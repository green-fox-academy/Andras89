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
        Fibonacciziator fibo = new Fibonacciziator();

        [TestCase(0)]
        public void WhatsIsIndexZero(int index)
        {
            Assert.AreEqual(0, fibo.FibonacciMaker(index));
        }

        [TestCase(1)]
        public void WhatsIsIndexOne(int index)
        {
            Assert.AreEqual(1, fibo.FibonacciMaker(index));
        }

        [TestCase(2)]
        public void WhatsIsIndexTwo(int index)
        {
            Assert.AreEqual(1, fibo.FibonacciMaker(index));
        }

        [TestCase(-1)]
        public void WhatsIsIndexMinusOne(int index)
        {
            Assert.AreEqual(0, fibo.FibonacciMaker(index));
        }

        [TestCase("a")]
        public void WhatsIsIndexA(int index)
        {
            Assert.Throws<ArgumentException>(() => fibo.FibonacciMaker(index));
        }
    }
}
