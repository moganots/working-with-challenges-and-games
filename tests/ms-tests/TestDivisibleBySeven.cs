using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IDivisibleBySeven and DivisibleBySeven
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestDivisibleBySeven
    {
        private IDivisibleBySeven instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new DivisibleBySeven();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
