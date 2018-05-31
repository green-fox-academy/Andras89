using Apples;
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
        private Apple shineyRedApple;

        [SetUp]
        public void SetUp()
        {
            shineyRedApple = new Apple();
        }

        [TearDown]
        public void TearDown()
        {
            shineyRedApple = null;
        }

        [TestCase("aple")]
        public void Tester(string apple)
        {
            Assert.AreEqual(apple, shineyRedApple.GetApple());
        }
    }
}
