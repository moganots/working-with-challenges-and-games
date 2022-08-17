using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the INumberOfWordsWithKMaximumDistinctVowels and NumberOfWordsWithKMaximumDistinctVowels
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestNumberOfWordsWithKMaximumDistinctVowels
    {
        private INumberOfWordsWithKMaximumDistinctVowels instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new NumberOfWordsWithKMaximumDistinctVowels();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
