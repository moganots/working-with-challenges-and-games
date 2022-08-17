using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IValidateAnIpAddress and ValidateAnIpAddress
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestValidateAnIpAddress
    {
        private IValidateAnIpAddress instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ValidateAnIpAddress();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
