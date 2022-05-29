using System;
using System.Text;

namespace StringExtension
{
    public static class CustomStringExtensions
    {
        public static int CustomCompareTo(this string thisString, string otherString)
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

        public static string CustomConcat(this string thisString, string otherString)
        {
            if (thisString == null || otherString == null)
                throw new ArgumentNullException();
            return thisString + otherString;
        }

        public static bool CustomContains(this string thisString, string otherString)
        {
            if (thisString.CustomIsNullOrEmpty() || otherString.CustomIsNullOrEmpty())
                throw new ArgumentNullException();
            if (otherString.Length > thisString.Length)
                return false;
            for (int i = 0; i <= thisString.Length - otherString.Length; i++)
            {
                if (thisString[i] == otherString[0])
                {
                    if (thisString.CustomSubstring(i, otherString.Length) == otherString)
                        return true;
                }
            }

            return false;
        }

        public static bool CustomEquals(this string thisString, string otherString)
        {
            if (thisString == null || otherString == null)
                return thisString == otherString;

            if (thisString.Length != otherString.Length)
                return false;

            for (int i = 0; i < thisString.Length; i++)
            {
                if (thisString[i] != otherString[i])
                    return false;
            }

            return true;
        }

        public static int CustomIndexOf(this string thisString, string otherString)
        {
            if (thisString == null || otherString == null || thisString == String.Empty || otherString == String.Empty)
                throw new ArgumentException();
            if (otherString.Length > thisString.Length)
                return -1;
            for (int i = 0; i <= thisString.Length - otherString.Length; i++)
            {
                if (thisString[i] == otherString[0])
                {
                    bool equals = true;
                    for (int j = 0; j < otherString.Length; j++)
                    {
                        if (thisString[i + j] != otherString[j])
                            equals = false;
                    }

                    if (equals)
                        return i;
                }
            }

            return -1;
        }

        public static int CustomIndexOfAny(this string thisString, char[] anyOf)
        {
            foreach (var c in anyOf)
            {
                var indexOf = thisString.CustomIndexOf(c.ToString());
                if (indexOf != -1) return indexOf;
            }

            return -1;
        }

        public static string CustomInsert(this string thisString, string otherString, int startIndex)
        {
            if (thisString == null || otherString == null || startIndex >= thisString.Length)
                throw new ArgumentException();
            return thisString.CustomSubstring(0, startIndex) + otherString + thisString.CustomSubstring(startIndex);
        }

        public static string CustomJoin(this string thisString, params string[] strings)
        {
            if (thisString == null)
                throw new ArgumentException();
            StringBuilder output = new StringBuilder();
            foreach (var s in strings)
            {
                output.Append($"{s}{thisString}");
            }

            return output.ToString().CustomSubstring(0, output.Length - thisString.Length);
        }

        public static int CustomLastIndexOf(this string thisString, string otherString)
        {
            if (thisString == null || otherString == null || thisString == String.Empty || otherString == String.Empty)
                throw new ArgumentException();
            if (otherString.Length > thisString.Length)
                return -1;
            for (int i = thisString.Length - otherString.Length; i >= 0; i--)
            {
                if (thisString[i] == otherString[0])
                {
                    bool equals = true;
                    for (int j = 0; j < otherString.Length; j++)
                    {
                        if (thisString[i + j] != otherString[j])
                            equals = false;
                    }

                    if (equals)
                        return i;
                }
            }

            return -1;
        }

        public static string CustomSubstring(this string thisString, int startIndex, int count)
        {
            if (thisString == null || startIndex < 0 || count < 0 || startIndex > thisString.Length - 1 || startIndex + count > thisString.Length)
                throw new ArgumentException();

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < thisString.Length; i++)
            {
                if (i >= startIndex && i < startIndex + count)
                    output.Append(thisString[i]);
            }

            return output.ToString();
        }

        public static string CustomSubstring(this string thisString, int startIndex)
        {
            if (thisString == null || startIndex < 0 || startIndex > thisString.Length - 1)
                throw new ArgumentException();
            int count = thisString.Length - startIndex;
            return thisString.CustomSubstring(startIndex, count);
        }

        public static string CustomRemove(this string thisString, int startIndex, int count)
        {
            if (thisString == null || startIndex < 0 || count < 0 || startIndex > thisString.Length - 1 || startIndex + count > thisString.Length)
                throw new ArgumentException();
            return thisString.CustomSubstring(0, startIndex) + thisString.CustomSubstring(startIndex + count);
        }

        public static string CustomReplace(this string thisString, string stringToReplace, string stringToPaste)
        {
            if (thisString == null || stringToPaste == null || stringToReplace == null || stringToReplace == String.Empty)
                throw new ArgumentException();
            if (!thisString.CustomContains(stringToReplace))
                return thisString;
            StringBuilder output = new StringBuilder();
            for (int i = 0; i <= thisString.Length - stringToReplace.Length; i++)
            {
                if (thisString[i] == stringToReplace[0])
                {
                    bool equals = true;
                    for (int j = 0; j < stringToReplace.Length; j++)
                    {
                        if (thisString[i + j] != stringToReplace[j])
                            equals = false;
                    }

                    if (equals)
                    {
                        output.Append(stringToPaste);
                        i = i + stringToReplace.Length - 1;
                    }
                }
                else
                {
                    output.Append(thisString[i]);
                }
            }

            return output.ToString();
        }

        public static string CustomToLower(this string thisString)
        {
            if (thisString == null)
                throw new ArgumentException();
            StringBuilder output = new StringBuilder();
            foreach (var c in thisString)
            {
                int code = c;

                if (code >= 65 && code <= 90)
                {
                    output.Append((char) (code + 32));
                }
                else
                {
                    output.Append(c);
                }
            }

            return output.ToString();
        }

        public static string CustomToUpper(this string thisString)
        {
            if (thisString == null)
                throw new ArgumentException();
            StringBuilder output = new StringBuilder();
            foreach (var c in thisString)
            {
                int code = c;

                if (code >= 97 && code <= 122)
                {
                    output.Append((char) (code - 32));
                }
                else
                {
                    output.Append(c);
                }
            }

            return output.ToString();
        }

        public static string CustomTrim(this string thisString)
        {
            if (thisString.CustomIsNullOrEmpty())
                throw new ArgumentException();
            return thisString.CustomTrimStart().CustomTrimEnd();
        }

        public static string CustomTrimStart(this string thisString)
        {
            if (thisString.CustomIsNullOrEmpty())
                throw new ArgumentException();
            StringBuilder output = new StringBuilder();
            int length = thisString.Length;
            bool startInside = false;
            for (int i = 0; i < length; i++)
            {
                if (!(startInside) && (thisString[i] == ' ' || thisString[i] == '\n' || thisString[i] == '\r' || thisString[i] == '\t'))
                {
                    continue;
                }
                else
                {
                    output.Append(thisString[i]);
                    startInside = true;
                }
            }

            return output.ToString();
        }

        public static string CustomTrimEnd(this string thisString)
        {
            if (thisString.CustomIsNullOrEmpty())
                throw new ArgumentException();
            int indexToTrim = -1;
            for (int i = thisString.Length - 1; i <= 0; i--)
            {
                if (thisString[i] == ' ' || thisString[i] == '\n' || thisString[i] == '\r' || thisString[i] == '\t')
                {
                    indexToTrim = i;
                }
            }

            if (indexToTrim != -1)
            {
                return thisString.CustomSubstring(0, indexToTrim);
            }

            return thisString;
        }
    }
}