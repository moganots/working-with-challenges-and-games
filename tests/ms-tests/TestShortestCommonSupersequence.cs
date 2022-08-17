using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IShortestCommonSupersequence and ShortestCommonSupersequence
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestShortestCommonSupersequence
    {
        private IShortestCommonSupersequence instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ShortestCommonSupersequence();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
