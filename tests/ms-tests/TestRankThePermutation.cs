using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IRankThePermutation and RankThePermutation
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestRankThePermutation
    {
        private IRankThePermutation instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new RankThePermutation();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
