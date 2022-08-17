using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ICountTheOccurrenceOfAGivenCharacterInAString and CountTheOccurrenceOfAGivenCharacterInAString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestCountTheOccurrenceOfAGivenCharacterInAString
    {
        private ICountTheOccurrenceOfAGivenCharacterInAString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new CountTheOccurrenceOfAGivenCharacterInAString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
