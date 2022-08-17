using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ISubstringsOfLengthKWithKOneDistinctElements and SubstringsOfLengthKWithKOneDistinctElements
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestSubstringsOfLengthKWithKOneDistinctElements
    {
        private ISubstringsOfLengthKWithKOneDistinctElements instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SubstringsOfLengthKWithKOneDistinctElements();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
