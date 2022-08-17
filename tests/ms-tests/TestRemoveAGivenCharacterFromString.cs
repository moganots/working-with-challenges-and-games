using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IRemoveAGivenCharacterFromString and RemoveAGivenCharacterFromString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestRemoveAGivenCharacterFromString
    {
        private IRemoveAGivenCharacterFromString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new RemoveAGivenCharacterFromString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
