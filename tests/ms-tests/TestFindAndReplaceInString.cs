using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindAndReplaceInString and FindAndReplaceInString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindAndReplaceInString
    {
        private IFindAndReplaceInString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindAndReplaceInString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
