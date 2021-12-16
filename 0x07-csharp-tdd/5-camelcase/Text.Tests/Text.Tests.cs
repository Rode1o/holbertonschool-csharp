using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary> Tests. </summary>
    public class StrTests
    {
        [Test]
        public void Main()
        {
            string s = "hello Good Morning.";

            int result = Str.CamelCase(s);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void noCamelCase()
        {
            string s = "hello good morning";

            int result = Str.CamelCase(s);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void oneWord()
        {
            string s = "hello";

            int result = Str.CamelCase(s);

            Assert.AreEqual(1, result);
        }


        [Test]
        public void Empty()
        {
            string s = "";

            int result = Str.CamelCase(s);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void NUll()
        {
            string s = null;

            int result = Str.CamelCase(s);

            Assert.AreEqual(0, result);
        }
    }
}