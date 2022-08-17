using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindDuplicateCharactersInAGivenString and FindDuplicateCharactersInAGivenString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindDuplicateCharactersInAGivenString
    {
        private IFindDuplicateCharactersInAGivenString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindDuplicateCharactersInAGivenString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
