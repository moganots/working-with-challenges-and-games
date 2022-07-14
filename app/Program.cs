using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var value = "fffiiiiiillteeeeeeeeeerrrd";
            var output = CountOfLettersUsingForLoopWithStringBuilder(value);
            Console.WriteLine($"Method => CountOfLettersUsingForLoopWithStringBuilder(), Input => {value}, Output => {output}");
            var outputTuple = CountOfLettersUsingForLoopWithYieldTuple(value);
            Console.WriteLine($"Method => CountOfLettersUsingForLoopWithYieldTuple(), Input => {value}, Output => {FormatTupleOutput(outputTuple)}");
            output = CountOfLettersUsingLinqGroupByStringJoin(value);
            Console.WriteLine($"Method => CountOfLettersUsingLinqGroupByStringJoin(), Input => {value}, Output => {output}");
            output = CountOfLettersUsingLinqGroupByTupleStringJoin(value);
            Console.WriteLine($"Method => CountOfLettersUsingLinqGroupByTupleStringJoin(), Input => {value}, Output => {output}");
            output = CountOfLettersUsingDictionaryWithStringBuilder(value);
            Console.WriteLine($"Method => CountOfLettersUsingDictionaryWithStringBuilder(), Input => {value}, Output => {output}");
            output = CountOfLettersUsingRegexWithStringBuilder(value);
            Console.WriteLine($"Method => CountOfLettersUsingRegexWithStringBuilder(), Input => {value}, Output => {output}");
            Console.WriteLine("\r\nPress any key to Exit");
        }

        private static string CountOfLettersUsingForLoopWithStringBuilder(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) return string.Empty;
            StringBuilder sb = new StringBuilder();
            char[] valueChars = value?.ToCharArray();
            char? previous = null;
            var count = 0;
            foreach (char current in valueChars)
            {
                if (previous == null) { ++count; previous = current; }
                else if (previous == current) { ++count; }
                else if (previous != current || count == 1)
                {
                    sb.Append($"{previous}{count}");
                    previous = current;
                    count = 1;
                }
            }
            return sb.ToString();
        }

        private static IEnumerable<Tuple<char, int>> CountOfLettersUsingForLoopWithYieldTuple(string value)
        {
            char[] valueChars = value?.ToCharArray();
            char? previous = null;
            var count = 0;
            foreach (char current in valueChars)
            {
                if (previous == null) { ++count; previous = current; }
                else if (previous == current) { ++count; }
                else if (previous != current)
                {
                    yield return new Tuple<char, int>((char)previous, count);
                    previous = current;
                    count = 1;
                }
            }
        }

        private static string CountOfLettersUsingLinqGroupByStringJoin(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) return string.Empty;
            var grouping = value?.ToCharArray()
                .GroupBy(letter => letter)
                .Select(grouped => new { letter = grouped.Key, count = grouped.Count() })
                .Select(grouped => $"{grouped.letter}{grouped.count}");
            return string.Join("", grouping);
        }

        private static string CountOfLettersUsingLinqGroupByTupleStringJoin(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) return string.Empty;
            var grouping = value?.ToCharArray()
                .GroupBy(letter => letter)
                .Select(grouped => new Tuple<char, int>(grouped.Key, grouped.Count()))
                .Select(grouped => $"{grouped.Item1}{grouped.Item2}");
            return string.Join("", grouping);
        }

        private static string CountOfLettersUsingDictionaryWithStringBuilder(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) return string.Empty;
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

        private static string CountOfLettersUsingRegexWithStringBuilder(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) return string.Empty;
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

        private static string FormatTupleOutput(IEnumerable<Tuple<char, int>> tuple)
        {
            return string.Join("", tuple.Select(ot => $"{ot.Item1}{ot.Item2}"));
        }
    }
}
