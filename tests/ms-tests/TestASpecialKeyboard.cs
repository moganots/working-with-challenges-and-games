using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IASpecialKeyboard and ASpecialKeyboard
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestASpecialKeyboard
    {
        private IASpecialKeyboard instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ASpecialKeyboard();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
