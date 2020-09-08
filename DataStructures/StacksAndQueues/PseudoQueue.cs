using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class PseudoQueue : IQueue
    {
        public Stack st1 = new Stack();
        public Stack st2 = new Stack();
        public int Length = 0;

        public void Enqueue(object value)
        {
            st1.Push(value);
            Length++;
        }

        public object Dequeue()
        {
            StackNode<object> curr = st1.Top;
            while (curr != null)
            {
                object value = st1.Pop();
                st2.Push(value);
                curr = curr.Next;
            }
            object popped = st2.Pop();
            curr = st2.Top;
            while (curr != null)
            {
                object popped2 = st2.Pop();
                st1.Push(popped2);
                curr = curr.Next;
            }
            Length--;
            return popped;
        }
    }
}