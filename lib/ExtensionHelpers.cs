using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lib
{
    public static class ExtensionHelpers
    {
        public static bool IsObjectSet(this object value)
        {
            return !(value == null);
        }
        public static bool IsStringSet(this string value)
        {
            return !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
        }
        public static bool IsSubStringOf(this object value, object checkValue)
        {
            return Regex.IsMatch(checkValue?.ToString(), value?.ToString());
        }
    }
}
