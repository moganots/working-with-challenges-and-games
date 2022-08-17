using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IEditDistance and EditDistance
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestEditDistance
    {
        private IEditDistance instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new EditDistance();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
