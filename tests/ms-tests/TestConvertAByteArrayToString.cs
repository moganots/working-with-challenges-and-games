using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IConvertAByteArrayToString and ConvertAByteArrayToString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestConvertAByteArrayToString
    {
        private IConvertAByteArrayToString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ConvertAByteArrayToString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
