using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    class StackNode
    {
        public StackNode(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public StackNode Next { get; set; }
    }
}
