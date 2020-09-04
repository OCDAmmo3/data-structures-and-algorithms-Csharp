using System;

namespace DataStructures.StacksAndQueues
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException(string method) : base($"This list is empty. Cannot {method}.")
        {

        }
    }
}
