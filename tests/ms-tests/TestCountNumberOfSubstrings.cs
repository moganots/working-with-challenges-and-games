using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICountNumberOfSubstrings and CountNumberOfSubstrings
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCountNumberOfSubstrings
    {
        private ICountNumberOfSubstrings instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CountNumberOfSubstrings();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
