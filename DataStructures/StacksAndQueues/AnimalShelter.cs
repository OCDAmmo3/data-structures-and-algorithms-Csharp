using System;
using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class Animal
    {
        public enum Type
        {
            Dog,
            Cat,
        }
    }

    public class AnimalShelter
    {
        public class Node
        {
            public Node(Animal.Type value)
            {
                Value = value;
            }

            public Animal.Type Value { get; set; }

            public Node Next { get; set; }
            public Node Prev { get; set; }
        }

        public Node Front { get; set; }
        public Node Back { get; set; }
        public int Length = 0;

        public void AEnqueue(Animal.Type animal)
        {
            Node node = new Node(animal);
            if (Front == null)
            {
                Front = node;
                Back = node;
            }
            else
            {
                Node temp = Back;
                Back = node;
                temp.Next = node;
                node.Prev = temp;
            }
            Length++;
        }

        public Animal.Type? ADequeue(Animal.Type pref)
        {
            Node curr = Front;
            Length--;
            if (pref == Animal.Type.Dog || pref == Animal.Type.Cat)
            {
                while (curr != null)
                {
                    if (curr.Value == pref)
                    {
                        Node temp = curr;
                        if (curr.Prev != null)
                            curr.Prev.Next = temp.Next;
                        if (curr.Next != null)
                            curr.Next.Prev = temp.Prev;
                        return curr.Value;
                    }
                    curr = curr.Next;
                    if (curr == Back)
                        break;
                }
                return null;
            }
            return null;
        }

        public Animal.Type? ADequeue()
        {
            Length--;
            if (Front != null)
                return Front.Value;
            return null;
        }

        public bool EmptyShelter()
        {
            return Front == null ? true : false;
        }
    }
}
