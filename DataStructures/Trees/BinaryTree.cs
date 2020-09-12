using DataStructures.StacksAndQueues;

namespace DataStructures.Trees
{

    public class BinaryTree<T>
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
    }
}
