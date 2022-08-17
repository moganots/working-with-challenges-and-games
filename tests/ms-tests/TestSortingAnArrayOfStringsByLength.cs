using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the ISortingAnArrayOfStringsByLength and SortingAnArrayOfStringsByLength
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestSortingAnArrayOfStringsByLength
    {
        private ISortingAnArrayOfStringsByLength instance;

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new SortingAnArrayOfStringsByLength();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
