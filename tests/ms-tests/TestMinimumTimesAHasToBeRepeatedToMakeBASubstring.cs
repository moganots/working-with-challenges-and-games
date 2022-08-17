using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IMinimumTimesAHasToBeRepeatedToMakeBASubstring and MinimumTimesAHasToBeRepeatedToMakeBASubstring
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestMinimumTimesAHasToBeRepeatedToMakeBASubstring
    {
        private IMinimumTimesAHasToBeRepeatedToMakeBASubstring instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new MinimumTimesAHasToBeRepeatedToMakeBASubstring();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
