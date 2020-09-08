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

        public object Pop()
        {
            if (Top == null)
                throw new EmptyStackException("pop");

            StackNode<object> temp = Top;
            Top = Top.Next;
            Size--;
            return temp.Value;
        }

        public object Peek()
        {
            if (Top == null)
                throw new EmptyStackException("peek");

            return Top.Value;
        }

        public bool IsEmpty()
        {
            return Top == null ? true : false;
        }

        public override string ToString()
        {
            StackNode<object> curr = Top;
            string str = "";
            if (Top != null)
            {
                while (curr.Next != null)
                {
                    str = $"{str}{curr.Value}, ";
                    curr = curr.Next;
                }
                str = $"{str}{curr.Value}";
            }
            else
            {
                str = "null";
            }
            return str;
        }
    }
}
