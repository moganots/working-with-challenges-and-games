using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindTheLengthOfTheLongestSubstringWithoutRepeatingCharacters and FindTheLengthOfTheLongestSubstringWithoutRepeatingCharacters
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindTheLengthOfTheLongestSubstringWithoutRepeatingCharacters
    {
        private IFindTheLengthOfTheLongestSubstringWithoutRepeatingCharacters instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindTheLengthOfTheLongestSubstringWithoutRepeatingCharacters();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
