using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Arrays
{
    public class Reverse
    {
        public static int[] ReverseArray(int[] array)
        {
            int[] result = new int[array.Length];
            for(int i = 1; i < array.Length + 1; i++)
            {
                result[i - 1] = array[array.Length - i];
            }
            return result;
        }
    }
}
