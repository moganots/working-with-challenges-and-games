using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IFindTheMaximumOccurringCharacterInAGivenString and FindTheMaximumOccurringCharacterInAGivenString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestFindTheMaximumOccurringCharacterInAGivenString
    {
        private IFindTheMaximumOccurringCharacterInAGivenString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new FindTheMaximumOccurringCharacterInAGivenString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
