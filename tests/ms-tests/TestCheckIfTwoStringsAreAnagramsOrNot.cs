using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICheckIfTwoStringsAreAnagramsOrNot and CheckIfTwoStringsAreAnagramsOrNot
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCheckIfTwoStringsAreAnagramsOrNot
    {
        private ICheckIfTwoStringsAreAnagramsOrNot instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CheckIfTwoStringsAreAnagramsOrNot();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
