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
			
			foreach(string className in classNames){
				string path = Path.Combine(dirLib, $"{className}.cs");
				string classData = classTemplate("lib", className);
				fileWrite(path, classData);
			}
		}catch(Exception exception){
			exception.Dump();
		}
		finally{}
}

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

// Define other methods and classes here
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
	sb.AppendLine("    /***********************************************************************************************");
	sb.AppendLine("     * ToDo: Description");
	sb.AppendLine("     ***********************************************************************************************/");
	sb.AppendLine($"    public class {className}");
	sb.AppendLine("    {");
	sb.AppendLine($"		public {className}(){{}}");
	sb.AppendLine("    }");
	sb.AppendLine("}");
	return sb.ToString();
}