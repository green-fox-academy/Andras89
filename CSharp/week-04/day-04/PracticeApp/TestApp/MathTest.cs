using NUnit.Framework;
using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    [TestFixture]
    public class MathTest
    {
        [Test]
        public void TestAdd()
        {
            Mathing test = new Mathing();
            Assert.AreEqual(20, test.Add(10, 10));
        }
    }
}
