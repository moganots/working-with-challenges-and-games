using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILookAndSayPattern and LookAndSayPattern
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLookAndSayPattern
    {
        private ILookAndSayPattern instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LookAndSayPattern();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
