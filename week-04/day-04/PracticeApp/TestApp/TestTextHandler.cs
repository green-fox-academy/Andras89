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
        TextHandler test = new TextHandler();

        [Test]
        public void TestMakeUpperCase()
        {
            Assert.AreEqual("ANDREW", test.MakeUpperCase("adrew"));
        }

        [Test]
        public void TestMakeLowerCase()
        {
            Assert.Catch<NotImplementedException>(() => test.MakeLowerCase("boo"));
        }
    }
}
