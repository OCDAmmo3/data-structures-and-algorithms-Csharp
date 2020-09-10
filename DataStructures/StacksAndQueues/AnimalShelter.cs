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

    class AnimalShelter
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
    }
}
