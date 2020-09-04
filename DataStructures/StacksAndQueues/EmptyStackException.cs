using System;

namespace DataStructures.StacksAndQueues
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException() : base("This list is empty. Cannot pop.")
        {

        }
    }
}
