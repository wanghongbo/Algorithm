using Algorithm.优先队列;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.优先队列 {
    [TestClass]
    public class PQTester {

        int[] a = { 5, 2, 1, 3, 8, 10, 4, 6, 7, 9 };

        [TestMethod]
        public void TestPQ() {
            MaxPQ pq = new MaxPQ(a.Length);
            Assert.AreEqual(pq.Size(), 0);
            foreach (int v in a) {
                pq.Insert(v);
            }
            for (int i = 10; i > 0; i--) {
                Assert.AreEqual(pq.Size(), i);
                int m = pq.DelMax();
                Assert.AreEqual(m, i);
            }
        }

        [TestMethod]
        public void TestIndexMinPQ() {
            IndexMinPQ pq = new IndexMinPQ(a.Length);

            for(int i = 0; i < a.Length; i++) {
                pq.Insert(i, a[i]);
            }

            Assert.AreEqual(pq.Min(), 1);
            Assert.AreEqual(pq.MinIndex(), 2);

            int indexOfMin = pq.DelMin();
            //{ 5, 2, X, 3, 8, 10, 4, 6, 7, 9 }，X表示已经删除的元素
            Assert.AreEqual(indexOfMin, 2);
            Assert.AreEqual(pq.Min(), 2);
            Assert.AreEqual(pq.MinIndex(), 1);

            pq.Delete(0);
            //{ X, 2, X, 3, 8, 10, 4, 6, 7, 9 }
            Assert.AreEqual(pq.Min(), 2);
            Assert.AreEqual(pq.MinIndex(), 1);

            pq.Delete(1);
            //{ X, X, X, 3, 8, 10, 4, 6, 7, 9 }
            Assert.AreEqual(pq.Min(), 3);
            Assert.AreEqual(pq.MinIndex(), 3);

            pq.Delete(9);
            //{ X, X, X, 3, 8, 10, 4, 6, 7, X }
            Assert.AreEqual(pq.Min(), 3);
            Assert.AreEqual(pq.MinIndex(), 3);

            pq.Change(5, 1);
            //{ X, X, X, 3, 8, 1, 4, 6, 7, X }
            Assert.AreEqual(pq.Min(), 1);
            Assert.AreEqual(pq.MinIndex(), 5);

            pq.Change(5, 9);
            //{ X, X, X, 3, 8, 9, 4, 6, 7, X }
            Assert.AreEqual(pq.Min(), 3);
            Assert.AreEqual(pq.MinIndex(), 3);
        }
    }
}
