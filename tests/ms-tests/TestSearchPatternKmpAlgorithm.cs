using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ISearchPatternKmpAlgorithm and SearchPatternKmpAlgorithm
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestSearchPatternKmpAlgorithm
    {
        private ISearchPatternKmpAlgorithm instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SearchPatternKmpAlgorithm();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
