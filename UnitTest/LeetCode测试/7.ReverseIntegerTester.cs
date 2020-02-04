using Algorithm.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.LeetCode测试 {

    [TestClass]
    public class ReverseIntegerTester {

        [TestMethod]
        public void TestCase() {
            Assert.AreEqual(ReverseInteger.Perform(0), 0);
            Assert.AreEqual(ReverseInteger.Perform(-123), -321);
            Assert.AreEqual(ReverseInteger.Perform(120), 21);
            Assert.AreEqual(ReverseInteger.Perform(10), 1);
            Assert.AreEqual(ReverseInteger.Perform(901000), 109);
            Assert.AreEqual(ReverseInteger.Perform(1534236469), 0);
            Assert.AreEqual(ReverseInteger.Perform(-2147483648), 0);
        }
    }
}
