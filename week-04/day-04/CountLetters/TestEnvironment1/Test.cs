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
        public void IsNumberOfAsEqualToNumber(string word)
        {
            Assert.AreEqual(2, dict.StringToDictionary(word)['a']);
        }
    }
}
