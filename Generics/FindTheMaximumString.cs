using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindTheMaximumString
    {
        public static string FindMaximumString(string firststring, string secondstring, string thridstring)
        {
            if (firststring.CompareTo(secondstring) >= 0 && firststring.CompareTo(thridstring) >= 0)
            {
                return firststring;
            }
            if (secondstring.CompareTo(firststring) >= 0 && secondstring.CompareTo(thridstring) >= 0)
            {
                return secondstring;
            }
            if (thridstring.CompareTo(firststring) >= 0 && thridstring.CompareTo(secondstring) >= 0)
            {
                return thridstring;
            }
            throw new Exception("firstString,secondString and thridString are same");
        }
    }
}
