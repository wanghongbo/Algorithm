using Algorithm.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests.LeetCode测试 {

    [TestClass]
    public class ThreeSumTester {

        [TestMethod]
        public void TestCase() {
            int[] nums = { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 };
            IList<IList<int>> lists = ThreeSum.Perform(nums);
        }
    }
}
