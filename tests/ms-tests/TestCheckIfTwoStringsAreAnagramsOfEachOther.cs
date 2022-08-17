using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICheckIfTwoStringsAreAnagramsOfEachOther and CheckIfTwoStringsAreAnagramsOfEachOther
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCheckIfTwoStringsAreAnagramsOfEachOther
    {
        private ICheckIfTwoStringsAreAnagramsOfEachOther instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CheckIfTwoStringsAreAnagramsOfEachOther();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
