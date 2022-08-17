using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ISearchPatternZAlgorithm and SearchPatternZAlgorithm
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestSearchPatternZAlgorithm
    {
        private ISearchPatternZAlgorithm instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SearchPatternZAlgorithm();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
