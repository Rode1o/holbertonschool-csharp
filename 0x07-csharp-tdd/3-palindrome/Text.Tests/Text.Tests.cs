using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary> Tests. </summary>
    public class Tests
    {
        [Test]
        public void ispalindrome()
        {
            string s = "Reconocer";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void notpalindrome()
        {
            string s = "Watermelon";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void punctuation()
        {
            string s = "A man, a plan, a canal: Panama.";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void empty()
        {
            string s = "";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }
    }
}