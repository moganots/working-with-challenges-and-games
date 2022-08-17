using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICountTheNumberOfVowelsAndConsonantsInAGivenString and CountTheNumberOfVowelsAndConsonantsInAGivenString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCountTheNumberOfVowelsAndConsonantsInAGivenString
    {
        private ICountTheNumberOfVowelsAndConsonantsInAGivenString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CountTheNumberOfVowelsAndConsonantsInAGivenString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
