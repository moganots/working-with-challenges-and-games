using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace lib
{
    /***************************************************************************************************************************************************
     * Defines the contract containing the declarations of methods, properties, indexers, and events for the IReverseAGivenStringInPlace interface
     ***************************************************************************************************************************************************/
    public interface IReverseAGivenStringInPlace
    {
        string ReverseUsingForLoopNoSwap(string swapString);
        string ReverseUsingForLoopNoSwapWithResultArray(string swapString);
        string ReverseUsingForLoopWithSwap(string swapString);
        string ReverseUsingForLoopWithInPlaceSwap(string swapString);
        string ReverseUsingForLoopWithoutCopyToCharArray(string swapString);
        string ReverseUsingForEachLoop(string swapString);
        string ReverseUsingForLoopWithXoR(string swapString);
        string ReverseUsingRecursion(string swapString);
        string ReverseUsingRecursionIndexingZero(string swapString);
    }

    /***************************************************************************************************************************************************
     * Provides implementation(s) for the methods, properties, indexers, and events for the IReverseAGivenStringInPlace interface
     ***************************************************************************************************************************************************/
    public class ReverseAGivenStringInPlace : IReverseAGivenStringInPlace
    {
		public ReverseAGivenStringInPlace(){ }
        public string ReverseUsingForLoopNoSwap(string swapString)
        {
            char[] swapCharArray = swapString.ToCharArray();
            string result = string.Empty;
            for (int i = swapCharArray.Length - 1; i >= 0; i--)
            {
                result += swapCharArray[i];
            }
            return result;
        }
        public string ReverseUsingForLoopNoSwapWithResultArray(string swapString)
        {
            char[] swapCharArray = swapString.ToCharArray();
            char[] result = new char[swapCharArray.Length];
            for (int i = swapCharArray.Length - 1; i >= 0; i--)
            {
                result[Math.Abs(result.Length - 1 - i)] = swapCharArray[i];
            }
            return new string(result);
        }
        public string ReverseUsingForLoopWithSwap(string swapString)
        {
            char[] swapCharArray = swapString.ToCharArray();
            for (int i = swapCharArray.Length - 1; i >= 0; i--)
            {
                char swapChar = swapCharArray[i];
                swapCharArray[Math.Abs(swapCharArray.Length - 1 - i)] = swapCharArray[i];
                swapCharArray[i] = swapChar;
            }
            return new string(swapCharArray);
        }
        public string ReverseUsingForLoopWithInPlaceSwap(string swapString)
        {
            return string.Empty;
        }
        public string ReverseUsingForLoopWithoutCopyToCharArray(string swapString)
        {
            return string.Empty;
        }
        public string ReverseUsingForEachLoop(string swapString)
        {
            return string.Empty;
        }
        public string ReverseUsingForLoopWithXoR(string swapString)
        {
            return string.Empty;
        }
        public string ReverseUsingRecursion(string swapString)
        {
            return string.Empty;
        }
        public string ReverseUsingRecursionIndexingZero(string swapString)
        {
            return string.Empty;
        }
    }
}
