using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILongestSubstringToFormAPalindrome and LongestSubstringToFormAPalindrome
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLongestSubstringToFormAPalindrome
    {
        private ILongestSubstringToFormAPalindrome instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LongestSubstringToFormAPalindrome();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
