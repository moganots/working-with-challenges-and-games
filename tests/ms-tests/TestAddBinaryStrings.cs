using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IAddBinaryStrings and AddBinaryStrings
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestAddBinaryStrings
    {
        private IAddBinaryStrings instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new AddBinaryStrings();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
