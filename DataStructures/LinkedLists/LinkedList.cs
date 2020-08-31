using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; } // defaults to null

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
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
        }

        public void InsertBefore(int value, int newVal)
        {
            if (!Includes(value))
            {
                throw new ArgumentException("Value given to insert before is not in list.");
            }

        }
    }
}
