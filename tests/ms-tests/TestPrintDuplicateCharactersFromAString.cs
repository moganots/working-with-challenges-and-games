using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IPrintDuplicateCharactersFromAString and PrintDuplicateCharactersFromAString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestPrintDuplicateCharactersFromAString
    {
        private IPrintDuplicateCharactersFromAString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new PrintDuplicateCharactersFromAString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
