using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Arrays
{
    public class ShiftInsert
    {
        public static int[] ShiftInserter(int[] array, int value)
        {
            int[] result = new int[array.Length + 1];

            int correct = array.Length % 2 == 0 ? array.Length : array.Length + 1;

            for(int i = 0; i < (correct / 2); i++)
            {
                result[i] = array[i];
            }
            result[correct / 2] = value;
            for(int i = correct / 2; i < array.Length; i++)
            {
                result[i + 1] = array[i];
            }

            return result;
        }
    }
}
