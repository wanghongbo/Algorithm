using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;

namespace UnitTest
{
    [TestClass]
    public class SortTest
    {
        int[] a = { 11, 5, 17, 3, 1, 16, 12, 18, 7, 8, 20, 13, 10, 20, 9, 1, 2, 19, 4, 14, 10, 6, 5, 15, 8, 16 };
        int[] b = { 3, 11, 5, 17, 3, 1, 16, 12, 18, 7, 8, 20, 13, 10, 20, 9, 6, 1, 2, 19, 4, 14, 10, 6, 5, 15, 8, 16, 14 };
        int[] c = { 1 };
        int[] d = { };

        [TestMethod]
        public void TestSeletorSort()
        {
            CheckResult(SelectorSort.Sort(a));
            CheckResult(SelectorSort.Sort(b));
            CheckResult(SelectorSort.Sort(c));
            CheckResult(SelectorSort.Sort(d));
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            CheckResult(InsertionSort.Sort(a));
            CheckResult(InsertionSort.Sort(b));
            CheckResult(InsertionSort.Sort(c));
            CheckResult(InsertionSort.Sort(d));
        }

        [TestMethod]
        public void TestShellSort()
        {
            CheckResult(ShellSort.Sort(a));
            CheckResult(ShellSort.Sort(b));
            CheckResult(ShellSort.Sort(c));
            CheckResult(ShellSort.Sort(d));
        }

        [TestMethod]
        public void TestMergeSort()
        {
            CheckResult(MergeSort.Sort(a));
            CheckResult(MergeSort.Sort(b));
            CheckResult(MergeSort.Sort(c));
            CheckResult(MergeSort.Sort(d));
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
