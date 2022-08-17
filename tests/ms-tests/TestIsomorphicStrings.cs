using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IIsomorphicStrings and IsomorphicStrings
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestIsomorphicStrings
    {
        private IIsomorphicStrings instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new IsomorphicStrings();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
