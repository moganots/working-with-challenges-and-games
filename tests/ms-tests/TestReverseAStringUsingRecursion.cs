using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IReverseAStringUsingRecursion and ReverseAStringUsingRecursion
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestReverseAStringUsingRecursion
    {
        private IReverseAStringUsingRecursion instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ReverseAStringUsingRecursion();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
