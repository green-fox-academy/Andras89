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

        [TestCase("applesoda")]
        [TestCase("aaaaapplesoda")]
        public void IsNumberOfAsEqualToNumber(string word)
        {
            Assert.AreEqual(word.Count(x => x == 'a'), dict.StringToDictionary(word)[word[0]]);
        }
    }
}
