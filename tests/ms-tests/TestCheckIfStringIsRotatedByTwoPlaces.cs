using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICheckIfStringIsRotatedByTwoPlaces and CheckIfStringIsRotatedByTwoPlaces
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCheckIfStringIsRotatedByTwoPlaces
    {
        private ICheckIfStringIsRotatedByTwoPlaces instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CheckIfStringIsRotatedByTwoPlaces();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
