using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILengthOfLongestPrefixSuffix and LengthOfLongestPrefixSuffix
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLengthOfLongestPrefixSuffix
    {
        private ILengthOfLongestPrefixSuffix instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LengthOfLongestPrefixSuffix();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
