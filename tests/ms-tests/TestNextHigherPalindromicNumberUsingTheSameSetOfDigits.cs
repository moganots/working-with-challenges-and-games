using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the INextHigherPalindromicNumberUsingTheSameSetOfDigits and NextHigherPalindromicNumberUsingTheSameSetOfDigits
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestNextHigherPalindromicNumberUsingTheSameSetOfDigits
    {
        private INextHigherPalindromicNumberUsingTheSameSetOfDigits instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new NextHigherPalindromicNumberUsingTheSameSetOfDigits();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
