using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICheckingWhetherTwoStringsAreAnagrams and CheckingWhetherTwoStringsAreAnagrams
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCheckingWhetherTwoStringsAreAnagrams
    {
        private ICheckingWhetherTwoStringsAreAnagrams instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CheckingWhetherTwoStringsAreAnagrams();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
