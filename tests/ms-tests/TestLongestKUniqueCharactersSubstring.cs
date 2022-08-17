using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILongestKUniqueCharactersSubstring and LongestKUniqueCharactersSubstring
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLongestKUniqueCharactersSubstring
    {
        private ILongestKUniqueCharactersSubstring instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LongestKUniqueCharactersSubstring();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
