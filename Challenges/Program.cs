using Challenges.Arrays;
using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToReverse = new[] { 1, 2, 3, 4, 5 };

            int[] reversed = Reverse.ReverseArray(arrayToReverse);

            Console.WriteLine(String.Join(",", reversed));
        }
    }
}
