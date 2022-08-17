using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ISmallestWindowInStringContainingAllCharacters and SmallestWindowInStringContainingAllCharacters
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestSmallestWindowInStringContainingAllCharacters
    {
        private ISmallestWindowInStringContainingAllCharacters instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SmallestWindowInStringContainingAllCharacters();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
