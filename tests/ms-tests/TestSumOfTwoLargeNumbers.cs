using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ISumOfTwoLargeNumbers and SumOfTwoLargeNumbers
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestSumOfTwoLargeNumbers
    {
        private ISumOfTwoLargeNumbers instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SumOfTwoLargeNumbers();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
