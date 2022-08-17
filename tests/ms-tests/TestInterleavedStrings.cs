using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IInterleavedStrings and InterleavedStrings
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestInterleavedStrings
    {
        private IInterleavedStrings instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new InterleavedStrings();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
