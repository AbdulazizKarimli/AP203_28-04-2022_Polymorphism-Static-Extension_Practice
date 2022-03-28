using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionPractice
{
    static class Extensions
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0) return true;

            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0) return true;

            return false;
        }
        public static bool HasDigit(this string str)
        {
            foreach (var item in str)
            {
                if(char.IsDigit(item))
                    return true;
            }

            return false;
        }
        public static bool HasLower(this string str)
        {
            foreach (var item in str)
            {
                if (char.IsLower(item))
                    return true;
            }

            return false;
        }
        public static bool HasUpper(this string str)
        {
            foreach (var item in str)
            {
                if (char.IsUpper(item))
                    return true;
            }

            return false;
        }
        public static int FindCharCount(this string str, char c)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (item == c)
                    count++;
            }

            return count;
        }
    }
}
