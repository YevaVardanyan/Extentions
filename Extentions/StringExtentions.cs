using System;

namespace Extentions
{
    public static class StringExtentions
    {
        public static string _Reverse(this string source)
        {
            char temp;
            char[] arr = source.ToCharArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }

            return new string(arr);
        }
        public static string OnlyFirstLetterUp(this string source)
        {
            string b = source.ToLower();
            string a = source.Substring(0, 1);
            source = a.ToUpper() + b.Remove(0, 1);
            return source;
        }
        public static bool HasLetter(this string source, ref char letter)
        {
            bool res = false;
            string newSource = source.ToLower();
            for (int i = 0; i < newSource.Length; i++)
            {
                if (newSource[i] == letter)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
    }
}
