using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    public static class ListExtentions
    {
        public static bool HasElement(this List<int> source, ref int item)
        {
            bool res = false;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] == item)
                {
                    res = true;
                }
            }
            return res;
        }
        public static bool IsOdd(this int element)
        {
            return element % 2 == 0;
        }

        public static int GetMax(this List<int> source, out int max)
        {
            max = source[0];
            for (int i = 1; i < source.Count; i++)
            {
                if (source[i] > max)
                    max = source[i];
            }
            return max;
        }
        public static int GetMin(this List<int> source, out int min)
        {
            min = source[0];
            for (int i = 1; i < source.Count; i++)
            {
                if (source[i] < min)
                    min = source[i];
            }
            return min;
        }

        public static void DecreasingOrder(this List<int> source)
        {
            int temp;
            for (int i = 0; i < source.Count - 1; i++)
            {
                for (int j = i + 1; j < source.Count; j++)
                    if (source[i] < source[j])
                    {
                        temp = source[i];
                        source[i] = source[j];
                        source[j] = temp;
                    }
            }
        }

        public static void IncreasingOrder(this List<int> source)
        {
            int temp;
            for (int i = 0; i < source.Count - 1; i++)
            {
                for (int j = i + 1; j < source.Count; j++)
                    if (source[i] > source[j])
                    {
                        temp = source[i];
                        source[i] = source[j];
                        source[j] = temp;
                    }
            }
        }

        public static bool IsDevidedBy(this List<int> source, int number, out int num)
        {
            num = source[0];
            bool res = false;
            foreach (var item in source)
            {
                if (item % number == 0)
                {
                    num = item;
                    res = true;
                    break;
                }
            }
            return res;
        }
    }
}
