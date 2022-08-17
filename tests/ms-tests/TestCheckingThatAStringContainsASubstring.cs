using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICheckingThatAStringContainsASubstring and CheckingThatAStringContainsASubstring
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCheckingThatAStringContainsASubstring
    {
        private ICheckingThatAStringContainsASubstring instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CheckingThatAStringContainsASubstring();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
