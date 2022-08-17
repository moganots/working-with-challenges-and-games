using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the INumberOfDistinctSubsequences and NumberOfDistinctSubsequences
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestNumberOfDistinctSubsequences
    {
        private INumberOfDistinctSubsequences instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new NumberOfDistinctSubsequences();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
