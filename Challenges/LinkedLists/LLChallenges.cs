using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.LinkedLists;

namespace Challenges.LinkedLists
{
    public class LLChallenges
    {
        public static LinkedList Zipper(LinkedList list1, LinkedList list2)
        {
            Node curr1 = list1.Head;
            Node curr2 = list2.Head;
            LinkedList result = new LinkedList();

            while (curr1 != null || curr2 != null)
            {
                if (curr1 != null)
                {
                    result.Append(curr1.Value);
                    curr1 = curr1.Next;
                }
                if (curr2 != null)
                {
                    result.Append(curr2.Value);
                    curr2 = curr2.Next;
                }
            }
            return result;
        }
    }
}
