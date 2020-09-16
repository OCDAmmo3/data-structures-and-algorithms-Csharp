using DataStructures.LinkedLists;
using DataStructures.Trees;

namespace Challenges.Trees
{
    public class TreeChallenges
    {
        public static BinaryTree<string> FizzBuzzify(BinaryTree<int> tree)
        {
            if (tree.Root == null)
                return tree;
            if (tree.Root.Value.GetType() != typeof(int))
                throw new NotIntTreeException();

            BinaryTree<string> resultTree = new BinaryTree<string>();
            BinaryTree<string>.Node newRoot = resultTree.Root;

            BinaryTree<int>.Node root = tree.Root;
            if (root.Value % 15 == 0)
                newRoot = new BinaryTree<string>.Node("FizzBuzz");
            else if (root.Value % 5 == 0)
                newRoot = new BinaryTree<string>.Node("Buzz");
            else if (root.Value % 3 == 0)
                newRoot = new BinaryTree<string>.Node("Fizz");
            else
                newRoot = new BinaryTree<string>.Node(root.Value.ToString());

            if (root.Left != null)
                FizzBuzzify(root.Left, newRoot.Left, resultTree);
            if (root.Right != null)
                FizzBuzzify(root.Right, newRoot.Right, resultTree);

            return resultTree;
        }
    }
}
