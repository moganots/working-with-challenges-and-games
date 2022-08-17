using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindingTheFirstNonRepeatedCharacter and FindingTheFirstNonRepeatedCharacter
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindingTheFirstNonRepeatedCharacter
    {
        private IFindingTheFirstNonRepeatedCharacter instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindingTheFirstNonRepeatedCharacter();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
