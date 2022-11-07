using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaximumFloat
    {
        public static float FindMaximumFloatNumber(float firstvalue, float secondvalue, float thridvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thridvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thridvalue) > 0)
            {
                return secondvalue;
            }
            if (thridvalue.CompareTo(firstvalue) > 0 && thridvalue.CompareTo(secondvalue) > 0)
            {
                return thridvalue;
            }
            throw new Exception("firstNumber,secondNumber and thridNumber are same");
        }
    }
}
