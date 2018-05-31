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
        private Summer sum;

        [TestCase(0)]
        public void TesterForZero(int allSum)
        {
            sum = new Summer(new List<int>());

            Assert.AreEqual(allSum, sum.Sum());
        }

        [TestCase(1)]
        public void TesterForSingleElement(int allSum)
        {
            sum = new Summer(new List<int>() { 1 });

            Assert.AreEqual(allSum, sum.Sum());
        }

        [TestCase(20)]
        public void TesterForMultipleElement(int allSum)
        {
            sum = new Summer(new List<int>() { 1, 5, 8, 6 });

            Assert.AreEqual(allSum, sum.Sum());
        }


    }
}
