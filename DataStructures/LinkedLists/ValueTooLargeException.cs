using System;

namespace DataStructures.LinkedLists
{
    public class ValueTooLargeException : Exception
    {
        public ValueTooLargeException(int missingValue) : base($"Value {missingValue} is too big for this list.")
        {

        }
    }
}
