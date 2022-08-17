using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFormAPalindrome and FormAPalindrome
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFormAPalindrome
    {
        private IFormAPalindrome instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FormAPalindrome();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
