using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary> Tests. </summary>
    public class OperationsTests
    {
        [Test]
        public void maxpositive()
        {
            List<int> nums = new List<int> {5, 8, 9, 45, 33, -81, 1, 27};
            int result = Operations.Max(nums);

            Assert.AreEqual(45, result);
        }

        [Test]
        public void maxnegative()
        {
            List<int> nums = new List<int> {-5, -8, -9, -45, -33, -81};
            int result = Operations.Max(nums);

            Assert.AreEqual(-5, result);
        }

        [Test]
        public void zero()
        {
            List<int> nums = new List<int> {};
            int result = Operations.Max(nums);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void nulist()
        {
            List<int> nums = null;
            int result = Operations.Max(nums);

            Assert.AreEqual(0, result);
        }
    }
}