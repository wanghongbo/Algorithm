using Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class StringSortTest {

        [TestMethod]
        public void TestKeyIndexedCountingSort() {
            Node[] a = new Node[] {
                new Node("Anderson", 2),
                new Node("Brown", 3),
                new Node("Davis", 3),
                new Node("Garcia", 4),
                new Node("Harris", 1),
                new Node("Jackson", 3),
                new Node("Johnson", 4),
                new Node("Jones", 3),
                new Node("Martin", 1),
                new Node("Martinez", 2),
                new Node("Miller", 2),
                new Node("Moore", 1),
                new Node("Robinson", 2),
                new Node("Smith", 4),
                new Node("Taylor", 3),
                new Node("Thomas", 4),
                new Node("Thompson", 4),
                new Node("White", 2),
                new Node("Williams", 3),
                new Node("Wilson", 4)
            };
            Node[] b = new Node[] {
                new Node("Harris", 1),
                new Node("Martin", 1),
                new Node("Moore", 1),
                new Node("Anderson", 2),
                new Node("Martinez", 2),
                new Node("Miller", 2),
                new Node("Robinson", 2),
                new Node("White", 2),
                new Node("Brown", 3),
                new Node("Davis", 3),
                new Node("Jackson", 3),
                new Node("Jones", 3),
                new Node("Taylor", 3),
                new Node("Williams", 3),
                new Node("Garcia", 4),
                new Node("Johnson", 4),
                new Node("Smith", 4),
                new Node("Thomas", 4),
                new Node("Thompson", 4),
                new Node("Wilson", 4)
            };

            KeyIndexedCountingSort.Sort(a, 5);

            for (int i = 0; i < a.Length; i++) {
                Assert.AreEqual(a[i], b[i]);
            }
        }

        [TestMethod]
        public void TestLSDSort() {
            string[] a = new string[] {
                "4PGC938",
                "2IYE230",
                "3CI0720",
                "1ICK750",
                "1OHV845",
                "4JZY524",
                "1ICK750",
                "3CI0720",
                "1OHV845",
                "1OHV845",
                "2RLA629",
                "2RLA629",
                "3ATW723"
            };

            string[] b = new string[] {
                "1ICK750",
                "1ICK750",
                "1OHV845",
                "1OHV845",
                "1OHV845",
                "2IYE230",
                "2RLA629",
                "2RLA629",
                "3ATW723",
                "3CI0720",
                "3CI0720",
                "4JZY524",
                "4PGC938"
            };

            LSD.Sort(a, a[0].Length);

            for (int i = 0; i < a.Length; i++) {
                Assert.AreEqual(a[i], b[i]);
            }
        }
    }
}
