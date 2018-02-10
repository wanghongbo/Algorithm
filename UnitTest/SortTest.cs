using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;

namespace UnitTest
{
    [TestClass]
    public class SortTest
    {
        int[] a = { 11, 5, 17, 3, 1, 16, 12, 18, 7, 8, 20, 13, 10, 20, 9, 1, 2, 19, 4, 14, 10, 6, 5, 15, 8, 16 };

        [TestMethod]
        public void TestSeletorSort()
        {
            CheckResult(SelectorSort.Sort(a));
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            CheckResult(InsertionSort.Sort(a));
        }

        [TestMethod]
        public void TestShellSort()
        {
            CheckResult(ShellSort.Sort(a));
        }

        private void CheckResult(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    Assert.Fail();
                }
            }
        }
    }
}
