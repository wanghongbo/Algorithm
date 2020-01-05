using Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.LeetCode测试 {

    [TestClass]
    public class LongestSubstringTester {

        [TestMethod]
        public void TestCase1() {
            string s = "abcabcbb";
            int length = LongestSubstring.Perform(s);
            Assert.AreEqual(length, 3);
        }

        [TestMethod]
        public void TestCase2() {
            string s = "bbbbb";
            int length = LongestSubstring.Perform(s);
            Assert.AreEqual(length, 1);
        }

        [TestMethod]
        public void TestCase3() {
            string s = "pwwkew";
            int length = LongestSubstring.Perform(s);
            Assert.AreEqual(length, 3);
        }

        [TestMethod]
        public void TestCase4() {
            string s = "bcadeafbgk";
            int length = LongestSubstring.Perform(s);
            Assert.AreEqual(length, 7);
        }
    }
}
