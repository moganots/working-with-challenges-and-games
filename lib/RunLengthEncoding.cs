using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace lib
{
    public class RunLengthEncoding
    {
        public string UsingForLoopWithStringBuilder(string value)
        {
            if (!value.IsStringSet()) return string.Empty;
            StringBuilder sb = new StringBuilder();
            char? previous = null;
            var count = 0;
            foreach (char current in value.ToCharArray())
            {
                CompareAppendUsingStringBuilder(sb, ref previous, ref count, current);
            }
            // Add last counted char as well
            sb.Append($"{previous}{count}");
            return sb.ToString();
        }

        public IEnumerable<Tuple<char, int>> UsingForLoopWithYieldTuple(string value)
        {
            char? previous = null;
            var count = 0;
            foreach (char current in value.ToCharArray())
            {
                if (previous == null) { count++; previous = current; }
                else if (previous == current) { count++; }
                else if (previous != current)
                {
                    yield return new Tuple<char, int>((char)previous, count);
                    previous = current;
                    count = 1;
                }
            }
            // Yield last counted char as well
            yield return new Tuple<char, int>((char)previous, count);
        }

        public string UsingLinqGroupByWithStringJoin(string value)
        {
            if (!value.IsStringSet()) return string.Empty;
            var grouping = value.ToCharArray()
                .GroupBy(letter => letter)
                .Select(grouped => new { letter = grouped.Key, count = grouped.Count() })
                .Select(grouped => $"{grouped.letter}{grouped.count}");
            return string.Join("", grouping);
        }

        public string UsingLinqGroupByTupleWithStringJoin(string value)
        {
            if (!value.IsStringSet()) return string.Empty;
            var grouping = value.ToCharArray()
                .GroupBy(letter => letter)
                .Select(grouped => new Tuple<char, int>(grouped.Key, grouped.Count()))
                .Select(grouped => $"{grouped.Item1}{grouped.Item2}");
            return string.Join("", grouping);
        }

        public string UsingRegex(string value)
        {
            if (!value.IsStringSet()) return string.Empty;
            return Regex.Replace(value, @"(\D)\1*", m =>
            {
                return $"{m.Groups[1].Value[0]}{m.Groups[0].Value.Length}";
            });
        }

        public string UsingDictionaryWithStringBuilder(string value)
        {
            if (!value.IsStringSet()) return string.Empty;
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

        private static void CompareAppendUsingStringBuilder(StringBuilder sb, ref char? previous, ref int count, char current)
        {
            if (previous == null) { count++; previous = current; }
            else if (previous == current) { count++; }
            else if (previous != current)
            {
                sb.Append($"{previous}{count}");
                previous = current;
                count = 1;
            }
        }
    }
}
