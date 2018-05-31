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
        private List<int> integerList;
        private Summer sum;

        [SetUp]
        public void SetUp()
        {
            integerList = new List<int>() { 1, 5, 6, 8 };
            sum = new Summer(integerList);
        }

        [Test]
        public void Tester()
        {
            Asser
        }
    }
}
