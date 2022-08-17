using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILongestCommonPrefix and LongestCommonPrefix
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLongestCommonPrefix
    {
        private ILongestCommonPrefix instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LongestCommonPrefix();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
