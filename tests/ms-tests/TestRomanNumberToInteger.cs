using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IRomanNumberToInteger and RomanNumberToInteger
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestRomanNumberToInteger
    {
        private IRomanNumberToInteger instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new RomanNumberToInteger();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
