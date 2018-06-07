using NUnit.Framework;
using Sharpie;

namespace Test
{
    [TestFixture]
    public class Test
    {
        Shar sharpie;

        [SetUp]
        public void SetUp()
        {
            sharpie = new Shar("Black", 100f);            
        }

        [Test]
        public void NumberOfUsesLeftAfterUsage([Range(1, 99)] int input)
        {
            LoopIt(input);

            Assert.AreEqual(100 - input, sharpie.NumberOfUsesLeft());
        }

        public void LoopIt(int input)
        {
            for (int i = 0; i < input; i++)
            {
                sharpie.Use();
            }
        }
    }
}