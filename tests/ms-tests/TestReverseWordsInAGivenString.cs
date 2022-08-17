using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IReverseWordsInAGivenString and ReverseWordsInAGivenString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestReverseWordsInAGivenString
    {
        private IReverseWordsInAGivenString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ReverseWordsInAGivenString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
