using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinarySearchTree : BinaryTree<int>
    {
        public void Add(int value)
        {
            if (Root == null)
                Root = new Node(value);
            else if (value < Root.Value && Root.Left == null)
                Root.Left = new Node(value);
            else if (value > Root.Value && Root.Right == null)
                Root.Right = new Node(value);

            if (value < Root.Value)
                Add(value, Root.Left);
            if (value > Root.Value)
                Add(value, Root.Right);
        }

        public void Add(int value, Node root)
        {
            if (root == null)
                root = new Node(value);
            else if (value < root.Value && root.Left == null)
                root.Left = new Node(value);
            else if (value > root.Value && root.Right == null)
                root.Right = new Node(value);

            if (value < root.Value)
                Add(value, root.Left);
            if (value > root.Value)
                Add(value, root.Right);
        }

        public bool Contains(int value)
        {
            if (Root == null)
                return false;
            else if (Root.Value == value)
                return true;

            if (value < Root.Value)
                return Contains(value, Root.Left);
            else if (value > Root.Value)
                return Contains(value, Root.Right);
            return false;
        }

        public bool Contains(int value, Node root)
        {
            if (root == null)
                return false;
            else if (root.Value == value)
                return true;

            if (value < root.Value)
                return Contains(value, root.Left);
            else if (value > root.Value)
                return Contains(value, root.Right);
            return false;
        }
    }
}
