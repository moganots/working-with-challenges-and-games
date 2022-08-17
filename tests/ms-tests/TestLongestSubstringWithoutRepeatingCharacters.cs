using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILongestSubstringWithoutRepeatingCharacters and LongestSubstringWithoutRepeatingCharacters
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLongestSubstringWithoutRepeatingCharacters
    {
        private ILongestSubstringWithoutRepeatingCharacters instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LongestSubstringWithoutRepeatingCharacters();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
