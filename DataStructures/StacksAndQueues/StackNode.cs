using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class StackNode<T>
    {
        public StackNode(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public StackNode<T> Next { get; set; }
    }
}
