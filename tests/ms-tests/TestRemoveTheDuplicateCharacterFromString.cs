using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IRemoveTheDuplicateCharacterFromString and RemoveTheDuplicateCharacterFromString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestRemoveTheDuplicateCharacterFromString
    {
        private IRemoveTheDuplicateCharacterFromString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new RemoveTheDuplicateCharacterFromString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
