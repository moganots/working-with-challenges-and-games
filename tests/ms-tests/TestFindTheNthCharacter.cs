using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindTheNthCharacter and FindTheNthCharacter
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindTheNthCharacter
    {
        private IFindTheNthCharacter instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindTheNthCharacter();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
