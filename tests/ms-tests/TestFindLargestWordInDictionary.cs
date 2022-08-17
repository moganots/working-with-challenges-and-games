using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindLargestWordInDictionary and FindLargestWordInDictionary
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindLargestWordInDictionary
    {
        private IFindLargestWordInDictionary instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindLargestWordInDictionary();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
