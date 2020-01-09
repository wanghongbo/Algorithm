using Algorithm.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.LeetCode测试 {

    [TestClass]
    public class FindMedianSortedArraysTester {

        [TestMethod]
        public void TestCase1() {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            double result = FindMedianSortedArrays.Perform(nums1, nums2);
            Assert.AreEqual(result, 2.5);
        }

        [TestMethod]
        public void TestCase2() {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            double result = FindMedianSortedArrays.Perform(nums1, nums2);
            Assert.AreEqual(result, 2.0);
        }

        [TestMethod]
        public void TestCase3() {
            int[] nums1 = { 1, 3, 4, 7 };
            int[] nums2 = { 2 };
            double result = FindMedianSortedArrays.Perform(nums1, nums2);
            Assert.AreEqual(result, 3.0);
        }
    }
}
