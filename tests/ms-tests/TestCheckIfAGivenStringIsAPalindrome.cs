using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICheckIfAGivenStringIsAPalindrome and CheckIfAGivenStringIsAPalindrome
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCheckIfAGivenStringIsAPalindrome
    {
        private ICheckIfAGivenStringIsAPalindrome instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CheckIfAGivenStringIsAPalindrome();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
