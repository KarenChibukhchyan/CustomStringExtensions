using System;

namespace StringExtension
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = new String('-', 40);
            // -------------  CustomCompareTo ------------
            Console.WriteLine(s, 30);
            string first = "aa";
            string second = "ab";
            var result = first.CustomCompareTo(second);
            if (result < 0) Console.WriteLine($"{first} precedes {second}");
            else if (result > 0) Console.WriteLine($"{second} precedes {first}");
            else Console.WriteLine($"{second} equals {first}");
            Console.WriteLine();

            // -------------  CustomIsNullOrEmpty ------------
            Console.WriteLine(s, 30);
            first = "";
            second = null;
            string third = "123";
            Console.WriteLine($"String {first} is null or empty: {first.CustomIsNullOrEmpty()}");
            Console.WriteLine($"String {second} is null or empty: {second.CustomIsNullOrEmpty()}");
            Console.WriteLine($"String {third} is null or empty: {third.CustomIsNullOrEmpty()}");
            Console.WriteLine();

            // -------------  CustomConcat ------------
            Console.WriteLine(s, 30);
            Console.WriteLine($"Concatenation of {first} and {third}:  {first.CustomConcat(third)}");
            Console.WriteLine($"Concatenation of {third} and {third}:  {third.CustomConcat(third)}");
            Console.WriteLine();

            // -------------  CustomContains ------------
            Console.WriteLine(s, 30);
            first = "aabbcc";
            second = "abdsd";
            third = "bbb";
            string fourth = "cc";
            Console.WriteLine($"{first} contains {second}: {first.CustomContains(second)}");
            Console.WriteLine($"{first} contains {third}: {first.CustomContains(third)}");
            Console.WriteLine($"{first} contains {fourth}: {first.CustomContains(fourth)}");
            Console.WriteLine();

            // -------------  CustomEquals ------------
            Console.WriteLine(s, 30);
            first = "aabbcc";
            second = "abdsd";
            third = "aabbcc";
            Console.WriteLine($"{first} equals {second}: {first.CustomEquals(second)}");
            Console.WriteLine($"{first} equals {third}: {first.CustomEquals(third)}");
            Console.WriteLine();

            // -------------  CustomIndexOf ------------
            Console.WriteLine(s, 30);
            first = "aabbcc";
            second = "abb";
            third = "ccc";
            Console.WriteLine($"Index of {second} in {first}: {first.CustomIndexOf(second)}");
            Console.WriteLine($"Index of {third} in {first}: {first.CustomIndexOf(third)}");
            Console.WriteLine();

            // -------------  CustomIndexOfAny ------------
            Console.WriteLine(s, 30);
            first = "aabbcc";
            second = "wdskjklb";
            third = "aabbcc";
            Console.WriteLine($"Index of any {second} in {first}: {first.CustomIndexOfAny(second.ToCharArray())}");
            Console.WriteLine($"Index of any {third} in {first}: {first.CustomIndexOfAny(third.ToCharArray())}");
            Console.WriteLine();

            // -------------  CustomInsert ------------
            Console.WriteLine(s, 30);
            first = "aabbcc";
            second = "123";
            int index = 2;
            Console.WriteLine($"Insert of {second} in {first} at index {index}: {first.CustomInsert(second, index)}");
            Console.WriteLine();

            // -------------  CustomJoin ------------
            Console.WriteLine(s, 30);
            first = "jjj";
            second = "123";
            third = "456";
            fourth = "+9+";
            Console.WriteLine($"{second} join {third} with {first}: {first.CustomJoin(second, third, fourth)}");
            Console.WriteLine();

            // -------------  CustomLastIndexOf ------------
            Console.WriteLine(s, 30);
            first = "how do I convert";
            second = "nve";
            third = "aabbcc";
            Console.WriteLine($"Last index of {second} in {first}: {first.CustomLastIndexOf(second)}");
            Console.WriteLine($"Last index of {third} in {first}: {first.CustomLastIndexOf(third)}");
            Console.WriteLine();

            // -------------  CustomRemove ------------
            Console.WriteLine(s, 30);
            first = "How do I convert a cakes to a beer";
            int startIndex = 2;
            int count = 10;
            Console.WriteLine($"Remove from {first} with start index {startIndex} and {count}: {first.CustomRemove(startIndex, count)}");
            // count = 60;
            // Console.WriteLine($"Remove from {first} with start index {startIndex} and {count}: {first.CustomRemove(startIndex, count)}");
            Console.WriteLine();

            // -------------  CustomReplace ------------
            Console.WriteLine(s, 30);
            second = "e";
            third = "444";
            Console.WriteLine($"Replace in {first} value {second} with {third}: {first.CustomReplace(second, third)}");
            second = "eeee";
            third = "444";
            Console.WriteLine($"Replace in {first} value {second} with {third}: {first.CustomReplace(second, third)}");
            Console.WriteLine();

            // -------------  CustomToLower ------------
            Console.WriteLine(s, 30);
            first = "aDbCcc3/";
            second = "abdsd";
            Console.WriteLine($"{first} to lower: {first.CustomToLower()}");
            Console.WriteLine($"{second} to lower: {second.CustomToLower()}");
            Console.WriteLine();

            // -------------  CustomToUpper ------------
            Console.WriteLine(s, 30);
            first = "aDbCcc3/";
            second = "abdsd";
            Console.WriteLine($"{first} to upper: {first.CustomToUpper()}");
            Console.WriteLine($"{second} to upper: {second.CustomToUpper()}");
            Console.WriteLine();

            // -------------  CustomTrim ------------
            Console.WriteLine(s, 30);
            first = "  aabbcc  ";
            second = "1 abdsd      ";
            Console.WriteLine($"{first} after trimming : {first.CustomTrim()}");
            Console.WriteLine($"{second} after trimming: {first.CustomTrim()}");
            Console.WriteLine();

            // -------------  CustomTrimEnd ------------
            Console.WriteLine(s, 30);
            first = "  aabbcc  ";
            second = "1 abdsd      ";
            Console.WriteLine($"{first} after trimming of end: {first.CustomTrimEnd()}");
            Console.WriteLine($"{second} after trimming of end: {second.CustomTrimEnd()}");
            Console.WriteLine();

            // -------------  CustomTrimStart ------------
            Console.WriteLine(s, 30);
            first = "  aabbcc  ";
            second = "1 abdsd      ";
            Console.WriteLine($"{first} after trimming of start: {first.CustomTrimStart()}");
            Console.WriteLine($"{second} after trimming of start: {second.CustomTrimStart()}");
            Console.WriteLine();

            // -------------  CustomSubstring ------------
            Console.WriteLine(s, 30);
            first = "Hello World from Substring  ";
            startIndex = 3;
            count = 4;
            Console.WriteLine($"Substring of {first} with start index {startIndex}: {first.CustomSubstring(startIndex)}");
            Console.WriteLine($"Substring of {first} with start index {startIndex} and count {count}: {first.CustomSubstring(startIndex, count)}");
            Console.WriteLine();
        }
    }
}