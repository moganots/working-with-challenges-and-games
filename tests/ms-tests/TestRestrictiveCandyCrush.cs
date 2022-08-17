using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IRestrictiveCandyCrush and RestrictiveCandyCrush
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestRestrictiveCandyCrush
    {
        private IRestrictiveCandyCrush instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new RestrictiveCandyCrush();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
