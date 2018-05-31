using CountLetters;
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
        DictionLetter dict;

        [SetUp]
        public void SetUp()
        {
            dict = new DictionLetter();
        }

        [TestCase("a")]
        public void IsSingleAEquelToNumberOfAs(string word)
        {
            Assert.AreEqual(1, dict.StringToDictionary(word)[word[0]]);
        }

        [TestCase("")]
        public void IsEmptyStringEqualToNumber(string word)
        {
            Assert.AreEqual(0, dict.StringToDictionary(word)[word[0]]);
        }

        [TestCase("applesoda")]
        [TestCase("aaaaapplesoda")]
        public void IsNumberOfAsEqualToNumber(string word)
        {
            Assert.AreEqual(word.Count(x => x == 'a'), dict.StringToDictionary(word)[word[0]]);
        }
    }
}
