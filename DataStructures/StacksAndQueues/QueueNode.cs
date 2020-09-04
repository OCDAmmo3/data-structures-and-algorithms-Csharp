using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class QueueNode
    {
        public QueueNode(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public QueueNode Next { get; set; }

        public QueueNode Prev { get; set; }
    }
}
