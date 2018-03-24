using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;

namespace UnitTest {
    [TestClass]
    public class SortTest {
        private delegate int[] Sort(int[] a);
        private void CheckResult(int[][] array, Sort sort) {
            foreach (int[] a in array) {
                sort(a);
                for (int i = 0; i < a.Length - 1; i++) {
                    if (a[i] > a[i + 1]) {
                        Assert.Fail();
                        Console.Write(a[i]);
                    }
                }
                Console.WriteLine();
            }
        }

        int[][] a = new int[][] {
            new int[]  { 11, 5, 17, 3, 1, 16, 12, 18, 7, 8, 20, 13, 10, 20, 9, 1, 2, 19, 4, 14, 10, 6, 5, 15, 8, 16 },
            new int[] { 3, 11, 5, 17, 3, 1, 16, 12, 18, 7, 8, 20, 13, 10, 20, 9, 6, 1, 2, 19, 4, 14, 10, 6, 5, 15, 8, 16, 14 },
            new int[] { 1 },
            new int[] { },
            new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }
        };

        [TestMethod]
        public void TestSeletorSort() {
            CheckResult(a, SelectorSort.Sort);
        }

        [TestMethod]
        public void TestInsertionSort() {
            CheckResult(a, InsertionSort.Sort);
        }

        [TestMethod]
        public void TestShellSort() {
            CheckResult(a, ShellSort.Sort);
        }

        [TestMethod]
        public void TestMergeSort() {
            CheckResult(a, MergeSort.Sort);
        }

        [TestMethod]
        public void TestQuickSort() {
            CheckResult(a, QuickSort.Sort);
        }
    }
}
