using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IMinimumDeletions and MinimumDeletions
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestMinimumDeletions
    {
        private IMinimumDeletions instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new MinimumDeletions();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
