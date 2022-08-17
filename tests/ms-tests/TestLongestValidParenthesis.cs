using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILongestValidParenthesis and LongestValidParenthesis
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLongestValidParenthesis
    {
        private ILongestValidParenthesis instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LongestValidParenthesis();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
