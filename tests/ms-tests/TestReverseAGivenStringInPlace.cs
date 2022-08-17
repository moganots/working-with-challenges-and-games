using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IReverseAGivenStringInPlace and ReverseAGivenStringInPlace
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestReverseAGivenStringInPlace
    {
        private IReverseAGivenStringInPlace instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ReverseAGivenStringInPlace();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
