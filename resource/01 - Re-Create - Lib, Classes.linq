<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.DirectoryServices.AccountManagement.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.DirectoryServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.IO.dll</Reference>
  <Namespace>System.DirectoryServices.AccountManagement</Namespace>
</Query>

void Main()
{
	string[] classNames = {
			"ReverseWordsInAGivenString",
			"LongestCommonPrefix",
			"RomanNumberToInteger",
			"IntegerToRoman",
			"ClosestStrings",
			"DivisibleBySeven",
			"EncryptTheString",
			"EqualPointInAStringOfBrackets",
			"IsomorphicStrings",
			"CheckIfTwoStringsAreAnagramsOrNot",
			"PanagramChecking",
			"MinimumDeletions",
			"NumberOfDistinctSubsequences",
			"CheckIfStringIsRotatedByTwoPlaces",
			"ConvertAGivenStringIntoIntLikeTheAtoi",
			"ValidateAnIpAddress",
			"LicenseKeyFormatting",
			"FindLargestWordInDictionary",
			"EqualZero,One,AndTwo",
			"FindAndReplaceInString",
			"AddBinaryStrings",
			"SumOfTwoLargeNumbers",
			"MultiplyTwoStrings",
			"LookAndSayPattern",
			"MinimumTimesAHasToBeRepeatedToMakeBASubstring",
			"FormAPalindrome",
			"FindTheNthCharacter",
			"NextHigherPalindromicNumberUsingTheSameSetOfDigits",
			"LengthOfLongestPrefixSuffix",
			"LongestKUniqueCharactersSubstring",
			"SmallestWindowInStringContainingAllCharacters",
			"LongestPalindromicSubsequence",
			"LongestSubstringWithoutRepeatingCharacters",
			"SubstringsOfLengthKWithKOneDistinctElements",
			"CountNumberOfSubstrings",
			"InterleavedStrings",
			"CheckingWhetherTwoStringsAreAnagrams",
			"RankThePermutation",
			"ASpecialKeyboard",
			"RestrictiveCandyCrush",
			"EditDistance",
			"SearchPatternKmpAlgorithm",
			"SearchPatternRabinKarpAlgorithm",
			"SearchPatternZAlgorithm",
			"ShortestCommonSupersequence",
			"NumberOfWordsWithKMaximumDistinctVowels",
			"LongestSubstringToFormAPalindrome",
			"LongestValidParenthesis",
			"DistinctPalindromicSubstrings",
			"PrintDuplicateCharactersFromAString",
			"RemoveAGivenCharacterFromString",
			"FindTheMaximumOccurringCharacterInAGivenString",
			"RemoveTheDuplicateCharacterFromString",
			"ConvertAByteArrayToString",
			"FindTheLongestPalindromicSubstringInString",
			"FindTheLengthOfTheLongestSubstringWithoutRepeatingCharacters",
			"CheckIfAGivenStringIsAPalindrome",
			"CheckIfTwoStringsAreARotationOfEachOther",
			"FindingTheFirstNonRepeatedCharacter",
			"CountTheOccurrenceOfAGivenCharacterInAString",
			"CountTheNumberOfVowelsAndConsonantsInAGivenString",
			"FindDuplicateCharactersInAGivenString",
			"CheckIfAStringContainsOnlyDigits",
			"ReverseAStringUsingRecursion",
			"FindAllThePermutationsOfAString",
			"CheckIfTwoStringsAreAnagramsOfEachOther",
			"PrintDuplicateCharactersFromAString",
			"ReverseAGivenStringInPlace",
			"CountingDuplicateCharacters",
			"SortingAnArrayOfStringsByLength",
			"CheckingThatAStringContainsASubstring"
		};
		
		try{		
			string dirCurrent = Directory.GetCurrentDirectory();
			string dirRoot = Directory.GetParent(dirCurrent).FullName;
			string dirResourse = Path.Combine(dirRoot, "resource");
			string dirApp = Path.Combine(dirRoot, "app");
			string dirLib = Path.Combine(dirRoot, "lib");
			string dirTests = Path.Combine(dirRoot, "tests");
			string dirMsTests = Path.Combine(dirTests, "ms-tests");
			
			foreach(string className in classNames){
				string path = Path.Combine(dirLib, $"{className}.cs");
				string classData = classTemplate("lib", className);
				fileWrite(path, classData);
				path = Path.Combine(dirMsTests, $"Test{className}.cs");
				classData = msTestsTemplate(className);
				fileWrite(path, classData);
			}
		}catch(Exception exception){
			exception.Dump();
		}
		finally{}
}

// Define other methods and classes here
private void directoryCreate(string path){
	if(!Directory.Exists(path)){
		Directory.CreateDirectory(path);
	}
}

private void directoryDelete(string path){
	if(Directory.Exists(path)){
		Directory.Delete(path);
	}
}

private void directoryDeleteRecursive(string path){
	if(Directory.Exists(path)){
		IEnumerable<string> files = Directory.EnumerateFiles(path);
		IEnumerable<string> directories = Directory.EnumerateDirectories(path);
		foreach(string file in files){
			fileDelete(file);
		}
		foreach(string directory in directories){
			directoryDeleteRecursive(directory);
		}
		directoryDelete(path);
	}
}

private void fileDelete(string path){
	if(File.Exists(path) && !fileIsLocked(new FileInfo(path))){
		File.Delete(path);
	}
}

private bool fileIsLocked(FileInfo file)
{
    try
    {
        using(FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
        {
            stream.Close();
        }
    }
    catch (IOException)
    {
        return true;
    }
    return false;
}

private void fileWrite(string path, string data){
	if(data != null){
		File.WriteAllText(path, data);
	}
}

private string splitCamelCase(string str)
{
    return System.Text.RegularExpressions.Regex.Replace(str, "([A-Z])", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim();
}

private string classTemplate(string nameSpace, string className) {
	StringBuilder sb = new StringBuilder();
	sb.AppendLine("using System;");
	sb.AppendLine("using System.Collections.Generic;");
	sb.AppendLine("using System.Linq;");
	sb.AppendLine("using System.Text;");
	sb.AppendLine("using System.Text.RegularExpressions;");
	sb.AppendLine("");
	sb.AppendLine($"namespace {nameSpace}");
	sb.AppendLine("{");
	sb.AppendLine("    /***************************************************************************************************************************************************");
	sb.AppendLine($"     * Defines the contract containing the declarations of methods, properties, indexers, and events for the I{className} interface");
	sb.AppendLine("     ***************************************************************************************************************************************************/");
	sb.AppendLine($"    public interface I{className}");
	sb.AppendLine("    {");
	sb.AppendLine("");
	sb.AppendLine("    }");
	sb.AppendLine("");
	sb.AppendLine("    /***************************************************************************************************************************************************");
	sb.AppendLine($"     * Provides implementation(s) for the methods, properties, indexers, and events for the I{className} interface");
	sb.AppendLine("     ***************************************************************************************************************************************************/");
	sb.AppendLine($"    public class {className} : I{className}");
	sb.AppendLine("    {");
	sb.AppendLine($"		public {className}(){{}}");
	sb.AppendLine("    }");
	sb.AppendLine("}");
	return sb.ToString();
}

private string msTestsTemplate(string className) {
	StringBuilder sb = new StringBuilder();
	sb.AppendLine("using lib;");
	sb.AppendLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
	sb.AppendLine("");
	sb.AppendLine("namespace ms_tests");
	sb.AppendLine("{");
	sb.AppendLine("    /***************************************************************************************************************************************************");
	sb.AppendLine($"     * Defines the test(s) for the I{className} and {className}");
	sb.AppendLine("     ***************************************************************************************************************************************************/");
	sb.AppendLine("    [TestClass]");
	sb.AppendLine($"    public class Test{className}");
	sb.AppendLine("    {");
	sb.AppendLine($"        private I{className} instance;");
	sb.AppendLine("");
	sb.AppendLine("        [TestInitialize]");
	sb.AppendLine("        public void TestInitialize()");
	sb.AppendLine("        {");
	sb.AppendLine($"            instance = new {className}();");
	sb.AppendLine($"            Assert.IsNotNull(instance);");
	sb.AppendLine("        }");
	sb.AppendLine("");
	sb.AppendLine("        [TestMethod]");
	sb.AppendLine("        public void TestMethod1()");
	sb.AppendLine("        {");
	sb.AppendLine("        }");
	sb.AppendLine("    }");
	sb.AppendLine("}");
	return sb.ToString();
}