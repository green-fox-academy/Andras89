﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Test
{
    [TestFixture]
    public class Test
    {
        Extension extension = new Extension();

        [Test]
        public void TestAdd_2and3is5()
        {
            Assert.AreEqual(5, extension.Add(2, 3));
        }

        [Test]
        public void TestAdd_1and4is5()
        {
            Assert.AreEqual(5, extension.Add(1, 4));
        }

        [TestCase(3,5)]
        public void TestAddTwoNumbers(int first, int second)
        {
            Assert.AreEqual(8, extension.Add(first, second));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(5, extension.MaxOfThree(5, 4, 3));
        }

        [Test]
        public void TestMaxOfThree_Fhird()
        {
            Assert.AreEqual(5, extension.MaxOfThree(3, 4, 5));
        }

        [Test]
        public void TestMaxOfThreeAnyThree()
        {
            Assert.AreEqual(5, extension.MaxOfThree(3, 4, 5));
        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(4, extension.Median(new List<int>() { 7, 5, 3, 5 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void TestMedianEight()
        {
            Assert.AreEqual(5.5, extension.Median(new List<int>() { 1, 2, 3, 4, 7, 6, 7, 8 }));
        }

        [Test]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Test]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Test]
        public void TestIsVowel_U()
        {
            Assert.True(extension.IsVowel('U'));
        }

        [Test]
        public void testTranslate_bemutatkozik()
        {
            Assert.AreEqual("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Test]
        public void testTranslate_kolbice()
        {
            Assert.AreEqual("lavagovopuvus", extension.Translate("lagopus"));
        }
    }
}
