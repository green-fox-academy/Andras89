using NUnit.Framework;
using Sum;
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
        Summer sum;

        [SetUp]
        public void SetUp()
        {
            sum = new Summer();
        }

        [TestCase(0)]
        public void TesterForZero(int allSum)
        {
            Assert.AreEqual(allSum, sum.Sum(new List<int>() { 0 }));
        }

        [TestCase(1)]
        public void TesterForSingleElement(int allSum)
        {
            Assert.AreEqual(allSum, sum.Sum(new List<int>() { 1 }));
        }

        [TestCase(20)]
        public void TesterForMultipleElement(int allSum)
        {
            Assert.AreEqual(allSum, sum.Sum(new List<int>() { 0, 3, 6, 8, 0, 2, 1 }));
        }

        [TestCase(null)]
        public void TesterForNull(Int32 allSum)
        {
            Assert.AreEqual(allSum, sum.Sum(new List<int>()));
        }
    }
}
