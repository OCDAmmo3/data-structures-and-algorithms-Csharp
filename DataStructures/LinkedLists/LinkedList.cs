using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; } // defaults to null
        public int Size = 0;

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
            Size++;
        }

        public bool Includes(int value)
        {
            Node curr = Head;
            while (curr != null)
            {
                if (curr.Value == value)
                {
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            Node curr = Head;
            while (curr != null)
            {
                str = $"{str}{{ {curr.Value} }} -> ";
                curr = curr.Next;
            }
            str = str + "null";
            return str;
        }

        public void Append(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
                return;
            }

            Node curr = Head;
            while (curr.Next != null)
                curr = curr.Next;

            curr.Next = new Node(value);
            Size++;
        }

        public void InsertBefore(int value, int newVal)
        {
            if (!Includes(value))
                throw new ValueMissingException(value);
            if (Head.Value == value)
                Insert(value);

            Node newNode = new Node(newVal);

            Node curr = Head;
            while (curr.Next.Value != value)
                curr = curr.Next;

            newNode.Next = curr.Next;
            curr.Next = newNode;
            Size++;
        }

        public void InsertAfter(int value, int newVal)
        {
            if (!Includes(value))
                throw new ValueMissingException(value);
            if (Head.Value == value)
                Append(value);

            Node newNode = new Node(newVal);

            Node curr = Head;
            while (curr.Value != value)
                curr = curr.Next;

            newNode.Next = curr.Next;
            curr.Next = newNode;
            Size++;
        }

        public int KthFromEnd(int value)
        {
            value = Math.Abs(value);
            if (value > this.Size || this.Size == 0)
                throw new ValueTooLargeException(value);

            Node curr = Head;
            for (int i = 1; i < this.Size - value; i++)
            {
                curr = curr.Next;
            }
            return curr.Value;
        }
    }
}
