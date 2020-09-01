using System;

namespace DataStructures.LinkedLists
{
    public class ValueMissingException : Exception
    {
        public ValueMissingException(int missingValue) : base($"Value {missingValue} is not in list.")
        {

        }
    }
}
