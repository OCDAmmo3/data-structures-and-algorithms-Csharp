using System;

namespace DataStructures.Trees
{
    public class EmptyTreeException : Exception
    {
        public EmptyTreeException() : base("This tree is empty. No maximum value.")
        {

        }
    }
}