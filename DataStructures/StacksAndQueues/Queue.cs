using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class Queue
    {
        public QueueNode<object> Front { get; set; }
        public QueueNode<object> Back { get; set; }

        public int Length = 0;

        public void Enqueue(object value)
        {
            QueueNode<object> newNode = new QueueNode<object>(value);
            if (Front == null)
            {
                Front = newNode;
                Back = newNode;
                Length++;
            }
            else
            {
                newNode.Prev = Back;
                Back.Next = newNode;
                Back = newNode;
                Length++;
            }
        }

        public override string ToString()
        {
            QueueNode<object> curr = Front;
            string str = "";
            while (curr.Next != null)
            {
                str = $"{str}{curr.Value}, ";
                curr = curr.Next;
            }
            str = $"{str}{curr.Value}";
            return str;
        }
    }
}
