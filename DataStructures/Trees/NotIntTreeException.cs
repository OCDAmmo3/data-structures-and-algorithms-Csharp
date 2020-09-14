using System;

namespace DataStructures.Trees
{
    public class NotIntTreeException : Exception
    {
        public NotIntTreeException() : base("I only work for int trees.")
        {

        }
    }
}