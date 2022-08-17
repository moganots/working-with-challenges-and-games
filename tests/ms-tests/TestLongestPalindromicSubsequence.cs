using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILongestPalindromicSubsequence and LongestPalindromicSubsequence
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLongestPalindromicSubsequence
    {
        private ILongestPalindromicSubsequence instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LongestPalindromicSubsequence();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
