using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class Stack
    {
        public StackNode<object> Top { get; set; }
        public int Size = 0;

        public void Push(object value)
        {
            StackNode<object> newNode = new StackNode<object>(value);
            newNode.Next = Top;
            Top = newNode;
            Size++;
        }

        public override string ToString()
        {
            StackNode<object> curr = Top;
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
