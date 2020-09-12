using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{

    class BinaryTree<T>
    {
        public class Node
        {
            public Node(T value)
            {
                Value = value;
            }
            public T Value { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }
        }

        public Node Root { get; set; }
        public int Length { get; set; }


    }
}
