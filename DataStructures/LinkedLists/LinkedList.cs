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
            Node newNode = new Node();
            newNode.Value = value;
            newNode.Next = Head;
            Head = newNode;
        }

        public bool Includes(int value)
        {
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
    }
}
