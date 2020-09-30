using System;
using System.Collections.Generic;
using System.Text;

namespace cccsharp
{
    public static class IntExtension
    {
        public static string ToRomeDigit(this int value)
        {
            String returnable;
            var symbArr = new String[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"};
            if(value < 11)
            {
                return returnable = symbArr[value - 1];
            }
            if(value < 40)
            {
                
            }
            return "unknown";
        }
    }
}
