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
        public int Length { get; set; }

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
    }
}
