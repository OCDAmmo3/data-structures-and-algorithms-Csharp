using DataStructures.Trees;

namespace Challenges.Trees
{
    public class TreeChallenges
    {
        public static BinaryTree<string> FizzBuzzify(BinaryTree<int> tree)
        {
            if (tree.Root == null)
                throw new EmptyTreeException();
            if (tree.Root.Value.GetType() != typeof(int))
                throw new NotIntTreeException();

            BinaryTree<int>.Node root = tree.Root;
            BinaryTree<string> resultTree = new BinaryTree<string>();
            resultTree.Root = new BinaryTree<string>.Node(FizzBuzz(root.Value));

            if (root.Left != null)
            {
                resultTree.Root.Left = new BinaryTree<string>.Node(FizzBuzz(root.Left.Value));
                FizzBuzzify(root.Left, resultTree.Root.Left, resultTree);
            }
            if (root.Right != null)
            {
                resultTree.Root.Right = new BinaryTree<string>.Node(FizzBuzz(root.Right.Value));
                FizzBuzzify(root.Right, resultTree.Root.Right, resultTree);
            }

            return resultTree;
        }

        public static BinaryTree<string> FizzBuzzify(BinaryTree<int>.Node root, BinaryTree<string>.Node newRoot, BinaryTree<string> resultTree)
        {
            BinaryTree<string>.Node prev = newRoot;

            if (root.Left != null)
            {
                newRoot.Left = new BinaryTree<string>.Node(FizzBuzz(root.Left.Value));
                FizzBuzzify(root.Left, newRoot.Left, resultTree);
            }
            if (root.Right != null)
            {
                newRoot.Right = new BinaryTree<string>.Node(FizzBuzz(root.Right.Value));
                FizzBuzzify(root.Right, newRoot.Right, resultTree);
            }

            if (root.Right == null && root.Left == null)
                prev.Value = FizzBuzz(root.Value);

            return resultTree;
        }

        public static string FizzBuzz(int value)
        {
            if (value % 15 == 0)
                return "FizzBuzz";
            else if (value % 5 == 0)
                return "Buzz";
            else if (value % 3 == 0)
                return "Fizz";
            else
                return value.ToString();
        }
    }
}
