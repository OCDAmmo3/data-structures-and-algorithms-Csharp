using DataStructures.StacksAndQueues;
using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace DataStructures.Trees
{

    public class BinaryTree<T>
        where T : IComparable<T>
    {
        public class Node
        {
            public Node(T value)
            {
                Value = value;
            }
            public T Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        public Node Root { get; set; }

        public string PreOrder(Node root)
        {
            Queue<T> queue = new Queue<T>();
            queue.Enqueue(root.Value);
            if (root.Left != null)
                PreOrder(root.Left, queue);
            if (root.Right != null)
                PreOrder(root.Right, queue);
            return queue.ToString();
        }

        public string PreOrder(Node root, Queue<T> queue)
        {
            queue.Enqueue(root.Value);
            if (root.Left != null)
                PreOrder(root.Left, queue);
            if (root.Right != null)
                PreOrder(root.Right, queue);
            return queue.ToString();
        }

        public string InOrder(Node root)
        {
            Queue<T> queue = new Queue<T>();
            if (root.Left != null)
                InOrder(root.Left, queue);
            queue.Enqueue(root.Value);
            if (root.Right != null)
                InOrder(root.Right, queue);
            return queue.ToString();
        }

        public string InOrder(Node root, Queue<T> queue)
        {
            if (root.Left != null)
                InOrder(root.Left, queue);
            queue.Enqueue(root.Value);
            if (root.Right != null)
                InOrder(root.Right, queue);
            return queue.ToString();
        }

        public string PostOrder(Node root)
        {
            Queue<T> queue = new Queue<T>();
            if (root.Left != null)
                PostOrder(root.Left, queue);
            if (root.Right != null)
                PostOrder(root.Right, queue);
            queue.Enqueue(root.Value);
            return queue.ToString();
        }

        public string PostOrder(Node root, Queue<T> queue)
        {
            if (root.Left != null)
                PostOrder(root.Left, queue);
            if (root.Right != null)
                PostOrder(root.Right, queue);
            queue.Enqueue(root.Value);
            return queue.ToString();
        }

        public T FindMaximumValue()
        {
            if (Root == null)
                throw new EmptyTreeException();
            if (Root.Value.GetType() != typeof(int))
                throw new NotIntTreeException();

            T max = Root.Value;

            Node root = Root;
            if (root.Left != null)
                max = FindMaximumValue(root.Left, max);
            if (root.Right != null)
                max = FindMaximumValue(root.Right, max);

            return max;
        }

        public T FindMaximumValue(Node root, T max)
        {
            if (root.Left != null)
            {
                max = max.CompareTo(root.Left.Value) > 0 ? max : root.Left.Value;
                FindMaximumValue(root.Left, max);
            }
            if (root.Right != null)
            {
                max = max.CompareTo(root.Right.Value) > 0 ? max : root.Right.Value;
                FindMaximumValue(root.Right, max);
            }
            return max;
        }

        public string BreadthFirst()
        {
            Queue<Node> queue = new Queue<Node>();
            Node root = Root;
            queue.Enqueue(root);

            System.Collections.Generic.List<T> list = new System.Collections.Generic.List<T>();

            bool didThrow = false;

            while (didThrow == false)
            {
                Node temp = queue.Dequeue();
                list.Add(temp.Value);

                if (temp.Left != null)
                    queue.Enqueue(temp.Left);

                if (temp.Right != null)
                    queue.Enqueue(temp.Right);

                try
                {
                    queue.Peek();
                }
                catch
                {
                    didThrow = true;
                }
            }
            return String.Join(", ", list);
        }
    }
}
