using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ISearchPatternRabinKarpAlgorithm and SearchPatternRabinKarpAlgorithm
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestSearchPatternRabinKarpAlgorithm
    {
        private ISearchPatternRabinKarpAlgorithm instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SearchPatternRabinKarpAlgorithm();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
