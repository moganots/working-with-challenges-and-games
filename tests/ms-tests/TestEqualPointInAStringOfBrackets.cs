using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IEqualPointInAStringOfBrackets and EqualPointInAStringOfBrackets
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestEqualPointInAStringOfBrackets
    {
        private IEqualPointInAStringOfBrackets instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new EqualPointInAStringOfBrackets();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
