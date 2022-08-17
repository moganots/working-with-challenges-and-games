using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IClosestStrings and ClosestStrings
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestClosestStrings
    {
        private IClosestStrings instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ClosestStrings();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
