using lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    /***************************************************************************************************************************************************
     * Defines the test(s) for the IReverseAGivenStringInPlace and ReverseAGivenStringInPlace
     ***************************************************************************************************************************************************/
    [TestClass]
    public class TestReverseAGivenStringInPlace
    {
        private IReverseAGivenStringInPlace instance;
        private string testCase = "TestCase";
        private string expectedResult = "esaCtseT";

        [TestInitialize]
        public void TestInitialize()
        {
            instance = new ReverseAGivenStringInPlace();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void Success_Test_ReverseUsingForLoopNoSwap()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingForLoopNoSwap(testCase));
        }

        [TestMethod]
        public void Success_Test_ReverseUsingForLoopNoSwapWithResultArray()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingForLoopNoSwapWithResultArray(testCase));
        }

        [TestMethod]
        public void Success_Test_ReverseUsingForLoopWithSwap()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingForLoopWithSwap(testCase));
        }

        [TestMethod]
        public void Success_Test_ReverseUsingForLoopWithInPlaceSwap()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingForLoopWithInPlaceSwap(testCase));
        }

        [TestMethod]
        public void Success_Test_ReverseUsingForLoopWithoutCopyToCharArray()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingForLoopWithoutCopyToCharArray(testCase));
        }

        [TestMethod]
        public void Success_Test_ReverseUsingForLoopWithXoR()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingForLoopWithXoR(testCase));
        }

        [TestMethod]
        public void Success_Test_ReverseUsingRecursion()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingRecursion(testCase));
        }

        [TestMethod]
        public void Success_Test_ReverseUsingRecursionIndexingZero()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingRecursionIndexingZero(testCase));
        }

        [TestMethod]
        public void Success_Test_ReverseUsingForEachLoop()
        {
            Assert.AreSame(expectedResult, instance.ReverseUsingForEachLoop(testCase));
        }
    }
}
