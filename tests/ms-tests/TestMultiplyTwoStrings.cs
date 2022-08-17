using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IMultiplyTwoStrings and MultiplyTwoStrings
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestMultiplyTwoStrings
    {
        private IMultiplyTwoStrings instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new MultiplyTwoStrings();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
