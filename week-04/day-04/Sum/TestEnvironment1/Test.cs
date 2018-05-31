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

        [SetUp]
        public void SetUp()
        {
            sum = new Summer(new List<int>());
        }

        [Test]
        public void Tester()
        {
            Assert.AreEqual(0, sum.Sum());
        }
    }
}
