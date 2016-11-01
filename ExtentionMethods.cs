using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class MyExtensions
    {
        public static string Capitalize(this String str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
