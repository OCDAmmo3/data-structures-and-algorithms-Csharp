using System;

namespace DataStructures.StacksAndQueues
{
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException(string method) : base($"This queue is empty. Cannot {method}.")
        {

        }
    }
}
