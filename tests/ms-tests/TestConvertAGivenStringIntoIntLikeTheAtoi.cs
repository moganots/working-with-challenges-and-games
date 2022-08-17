using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IConvertAGivenStringIntoIntLikeTheAtoi and ConvertAGivenStringIntoIntLikeTheAtoi
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestConvertAGivenStringIntoIntLikeTheAtoi
    {
        private IConvertAGivenStringIntoIntLikeTheAtoi instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ConvertAGivenStringIntoIntLikeTheAtoi();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
