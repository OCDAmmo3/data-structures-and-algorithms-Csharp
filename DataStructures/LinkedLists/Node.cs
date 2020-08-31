namespace DataStructures.LinkedLists
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Value of this node.
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Pointer to the next node in the list.
        /// </summary>
        public Node Next { get; set; }
    }
}
