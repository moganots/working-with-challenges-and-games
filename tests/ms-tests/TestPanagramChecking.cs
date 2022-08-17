using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IPanagramChecking and PanagramChecking
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestPanagramChecking
    {
        private IPanagramChecking instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new PanagramChecking();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
