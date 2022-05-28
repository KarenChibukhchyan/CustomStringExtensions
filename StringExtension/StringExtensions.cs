using System;

namespace StringExtension
{
    public static class CustomStringExtensions
    {
        public static int CustomCompare(this string thisString, string otherString)
        {
            if (thisString.CustomIsNullOrEmpty() || otherString.CustomIsNullOrEmpty())
                throw new ArgumentException("Cannot compare with empty string");
            for (int i = 0; i < thisString.Length; i++)
            {
                if (thisString[i] != otherString[i])
                {
                    return thisString[i] < otherString[i] ? -1 : 1;
                }
            }

            return 0;
        }

        public static bool CustomIsNullOrEmpty(this string thisString)
        {
            return !(thisString?.Length > 0);
        }
    }
}