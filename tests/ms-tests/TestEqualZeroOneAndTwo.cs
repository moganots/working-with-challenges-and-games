using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IEqualZeroOneAndTwo and EqualZeroOneAndTwo
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestEqualZeroOneAndTwo
    {
        private IEqualZeroOneAndTwo instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new EqualZeroOneAndTwo();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
