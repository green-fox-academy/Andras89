﻿using NUnit.Framework;
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
            Assert.AreEqual("ANDREW", test.MakeUpperCase("andrew"));
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