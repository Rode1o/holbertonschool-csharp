using NUnit.Framework;

namespace MyMath.Test
{
    [TestFixture]
    /// <summary> Tests. </summary>
    public class OperationsTests
    {
        [Test]
        public void positiveInt()
        {
            int result = Operations.Add(4, 7);
            Assert.AreEqual(11, result);
        }

        [Test]
        public void negativeInt()
        {
            int result = Operations.Add(4, -7);
            Assert.AreEqual(-3, result);
        }

        [Test]
        public void bothNegativeInt()
        {
            int result = Operations.Add(-6, -3);

            Assert.AreEqual(-9, result);
        }

        [Test]
        public void CeroInt()
        {
            int result = Operations.Add(0, -15);

            Assert.AreEqual(-15, result);
        }

         [Test]
        
        public void BothCeroInt()
        {
            int result = Operations.Add(0, 0);

            Assert.AreEqual(0, result);
        }
    }
}