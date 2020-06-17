using Algorithm.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.LeetCode测试 {

    [TestClass]
    public class ContainerWithMostWaterTester {

        [TestMethod]
        public void TestCase() {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Assert.AreEqual(ContainerWithMostWater.Perform(height), 49);
        }
    }
}
