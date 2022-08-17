using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICountingDuplicateCharacters and CountingDuplicateCharacters
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCountingDuplicateCharacters
    {
        private ICountingDuplicateCharacters instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CountingDuplicateCharacters();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
