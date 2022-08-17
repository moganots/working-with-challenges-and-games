using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IDistinctPalindromicSubstrings and DistinctPalindromicSubstrings
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestDistinctPalindromicSubstrings
    {
        private IDistinctPalindromicSubstrings instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new DistinctPalindromicSubstrings();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
