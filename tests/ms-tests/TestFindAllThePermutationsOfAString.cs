using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindAllThePermutationsOfAString and FindAllThePermutationsOfAString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindAllThePermutationsOfAString
    {
        private IFindAllThePermutationsOfAString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindAllThePermutationsOfAString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
