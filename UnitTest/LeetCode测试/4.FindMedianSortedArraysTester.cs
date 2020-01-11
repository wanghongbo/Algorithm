using Algorithm.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.LeetCode测试 {

    [TestClass]
    public class FindMedianSortedArraysTester {

        [TestMethod]
        public void TestCase1() {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 2.5);
        }

        [TestMethod]
        public void TestCase2() {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 2.0);
        }

        [TestMethod]
        public void TestCase3() {
            int[] nums1 = { 1, 3, 4, 7 };
            int[] nums2 = { 2 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 3.0);
        }

        [TestMethod]
        public void TestCase4() {
            int[] nums1 = { 1, 3, 4, 7 };
            int[] nums2 = { 0 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 3.0);
        }

        [TestMethod]
        public void TestCase5() {
            int[] nums1 = { 1, 3, 4, 7 };
            int[] nums2 = { 8 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 4.0);
        }

        [TestMethod]
        public void TestCase6() {
            int[] nums1 = { 1, 3, 4, 7 };
            int[] nums2 = { };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 3.5);
        }

        [TestMethod]
        public void TestCase7() {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4, 5, 6, 7, 8 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 4.5);
        }

        [TestMethod]
        public void TestCase8() {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4, 5, 6, 7 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 4.0);
        }

        [TestMethod]
        public void TestCase9() {
            int[] nums1 = { 9, 10 };
            int[] nums2 = { 3, 4, 5, 6, 7, 8 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 6.5);
        }

        [TestMethod]
        public void TestCase10() {
            int[] nums1 = { 9, 10 };
            int[] nums2 = { 3, 4, 5, 6, 7 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 6.0);
        }

        [TestMethod]
        public void TestCase11() {
            int[] nums1 = { 3 };
            int[] nums2 = { -2, -1 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, -1.0);
        }

        [TestMethod]
        public void TestCase12() {
            int[] nums1 = { 1, 1, 3, 3 };
            int[] nums2 = { 1, 1, 3, 3 };
            double result = Perform(nums1, nums2);
            Assert.AreEqual(result, 2.0);
        }

        public double Perform(int[] nums1, int[] nums2) {
            return FindMedianSortedArrays.Perform1(nums1, nums2);
        }
    }
}
