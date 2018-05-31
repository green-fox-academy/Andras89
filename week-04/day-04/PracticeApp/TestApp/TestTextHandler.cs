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
    public class TestTextHandler
    {
        private TextHandler test;

        [SetUp]
        public void SetUp()
        {
            test = new TextHandler();
        }

        [TearDown]
        public void TearDown()
        {
            test = null;
        }

        [TestCase("ANDREW", "andrew")]
        public void TestMakeUpperCase(string nameOne, string nameTwo)
        {
            Assert.AreEqual(nameOne, test.MakeUpperCase(nameTwo));
        }

        [Test]
        public void TestMakeLowerCase()
        {
            Assert.Catch<NotImplementedException>(() => test.MakeLowerCase("boo"));
        }

        [Test]
        public void TestMakeLowerCaseTwo()
        {
            try
            {
                test.MakeLowerCase("boo");
                Assert.Fail();
            }
            catch (NotImplementedException)
            {
                Assert.Pass();
            }
        }
    }
}
