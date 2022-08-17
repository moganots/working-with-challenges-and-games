using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ILicenseKeyFormatting and LicenseKeyFormatting
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestLicenseKeyFormatting
    {
        private ILicenseKeyFormatting instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new LicenseKeyFormatting();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
