using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public static class IsSubStringOf
    {
        public static bool? IsStringSubStringOf(this string value, string checkValue)
        {
            return value?.Contains(checkValue, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
