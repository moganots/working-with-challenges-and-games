using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICheckIfAStringContainsOnlyDigits and CheckIfAStringContainsOnlyDigits
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCheckIfAStringContainsOnlyDigits
    {
        private ICheckIfAStringContainsOnlyDigits instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CheckIfAStringContainsOnlyDigits();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
