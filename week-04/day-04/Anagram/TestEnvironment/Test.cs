using Anagram;
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
        InString anagram;

        [SetUp]
        public void SetUp()
        {
            anagram = new InString();
        }

        [TestCase("Ana", "Ana")]
        public void IsTheSameWord(string first, string second)
        {
            Assert.AreEqual(true, anagram.AreAnagrams(first, second));
        }
    }
}
