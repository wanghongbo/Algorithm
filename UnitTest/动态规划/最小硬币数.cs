using Algorithm.动态规划;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.动态规划 {

    [TestClass]
    public class MinCountOfCoinsTester {

        [TestMethod]
        public void TestCase() {
            Assert.AreEqual(MinCountOfCoins.Perform(2), 2);
            Assert.AreEqual(MinCountOfCoins.Perform(3), 1);
            Assert.AreEqual(MinCountOfCoins.Perform(4), 2);
            Assert.AreEqual(MinCountOfCoins.Perform(5), 1);
            Assert.AreEqual(MinCountOfCoins.Perform(6), 2);
            Assert.AreEqual(MinCountOfCoins.Perform(7), 3);
            Assert.AreEqual(MinCountOfCoins.Perform(8), 2);
            Assert.AreEqual(MinCountOfCoins.Perform(9), 3);
            Assert.AreEqual(MinCountOfCoins.Perform(10), 2);
        }
    }
}
