using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IEncryptTheString and EncryptTheString
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestEncryptTheString
    {
        private IEncryptTheString instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new EncryptTheString();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
