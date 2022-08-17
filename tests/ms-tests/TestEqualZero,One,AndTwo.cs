using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IEqualZero,One,AndTwo and EqualZero,One,AndTwo
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestEqualZero,One,AndTwo
    {
        private IEqualZero,One,AndTwo instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new EqualZero,One,AndTwo();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
