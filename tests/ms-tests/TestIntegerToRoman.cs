using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IIntegerToRoman and IntegerToRoman
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestIntegerToRoman
    {
        private IIntegerToRoman instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new IntegerToRoman();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
