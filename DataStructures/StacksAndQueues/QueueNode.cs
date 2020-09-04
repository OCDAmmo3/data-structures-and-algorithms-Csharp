using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class QueueNode<T>
    {
        public QueueNode(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public QueueNode<T> Next { get; set; }

        public QueueNode<T> Prev { get; set; }
    }
}
