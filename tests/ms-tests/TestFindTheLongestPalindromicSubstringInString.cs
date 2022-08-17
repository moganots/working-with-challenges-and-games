using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindTheLongestPalindromicSubstringInString and FindTheLongestPalindromicSubstringInString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindTheLongestPalindromicSubstringInString
    {
        private IFindTheLongestPalindromicSubstringInString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindTheLongestPalindromicSubstringInString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
