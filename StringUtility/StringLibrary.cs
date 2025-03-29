using System;

namespace StringUtilityLab4Ronald
{
    public static class StringLibraryExtensions
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }

        public static bool RonaldTest(this string str)
        {
            return true;
        }
    }
}

