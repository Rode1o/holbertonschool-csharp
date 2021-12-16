using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary> Tests. </summary>
    public class StrTests
    {
        [Test]
        public void firstUnique()
        {
            string s = "abebe";

            int result = Str.UniqueChar(s);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void uniqueEnd()
        {
            string s = "ababr";

            int result = Str.UniqueChar(s);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void oneLetter()
        {
            string s = "e";

            int result = Str.UniqueChar(s);

            Assert.AreEqual(0, result);
        }
        [Test]
        public void Empty()
        {
            string s = "";

            int result = Str.UniqueChar(s);

            Assert.AreEqual(-1, result);
        }
        [Test]
        public void noneUnique()
        {
            string s = "ababenen";

            int result = Str.UniqueChar(s);

            Assert.AreEqual(-1, result);
        }
        [Test]
        public void midUnique()
        {
            string s = "holaphola";

            int result = Str.UniqueChar(s);

            Assert.AreEqual(4, result);
        }
    }
}