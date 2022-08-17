using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICheckIfTwoStringsAreARotationOfEachOther and CheckIfTwoStringsAreARotationOfEachOther
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCheckIfTwoStringsAreARotationOfEachOther
    {
        private ICheckIfTwoStringsAreARotationOfEachOther instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CheckIfTwoStringsAreARotationOfEachOther();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
