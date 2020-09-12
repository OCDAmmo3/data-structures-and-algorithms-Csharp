using Xunit;
using DataStructures.Trees;

namespace DataStructures.Tests.Trees
{
    public class TreeTests
    {
        public static BinaryTree<string> CreateTree()
        {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Root = new BinaryTree<string>.Node("Root");
            tree.Root.Left = new BinaryTree<string>.Node("RootLeft");
            tree.Root.Right = new BinaryTree<string>.Node("RootRight");
            tree.Root.Left.Left = new BinaryTree<string>.Node("RootLeftLeft");
            tree.Root.Left.Right = new BinaryTree<string>.Node("RootLeftRight");
            tree.Root.Right.Left = new BinaryTree<string>.Node("RootRightLeft");
            tree.Root.Right.Right = new BinaryTree<string>.Node("RootRightRight");
            return tree;
        }

        [Fact]
        public void PreOrder_should_return_tree_down_left_then_down_right()
        {
            // Arrange
            BinaryTree<string> tree = CreateTree();

            // Act
            string result = tree.PreOrder(tree.Root);

            // Assert
            Assert.Equal("Root, RootLeft, RootLeftLeft, RootLeftRight, RootRight, RootRightLeft, RootRightRight", result);
        }

        [Fact]
        public void InOrder_should_return_tree_from_farthest_left_to_farthest_right()
        {
            // Arrange
            BinaryTree<string> tree = CreateTree();

            // Act
            string result = tree.InOrder(tree.Root);

            // Assert
            Assert.Equal("RootLeftLeft, RootLeft, RootLeftRight, Root, RootRightLeft, RootRight, RootRightRight", result);
        }

        [Fact]
        public void PostOrder_should_return_tree_from_bottom_up()
        {
            // Arrange
            BinaryTree<string> tree = CreateTree();

            // Act
            string result = tree.PostOrder(tree.Root);

            // Assert
            Assert.Equal("RootLeftLeft, RootLeftRight, RootLeft, RootRightLeft, RootRightRight, RootRight, Root", result);
        }

        [Fact]
        public void Add_works_for_binary_search_tree()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();

            // Act
            tree.Add(4);
            tree.Add(2);
            tree.Add(6);
            tree.Add(1);
            tree.Add(3);
            tree.Add(5);
            tree.Add(7);

            // Assert
            Assert.Equal("1, 2, 3, 4, 5, 6, 7", tree.InOrder(tree.Root));
            Assert.Equal("4, 2, 1, 3, 6, 5, 7", tree.PreOrder(tree.Root));
            Assert.Equal("1, 3, 2, 5, 7, 6, 4", tree.PostOrder(tree.Root));
        }

        [Fact]
        public void Contains_returns_true_for_value_in_search_tree()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(4);
            tree.Add(2);
            tree.Add(3);

            // Act
            bool result = tree.Contains(3);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Contains_returns_false_for_value_not_in_tree()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);

            // Act
            bool result = tree.Contains(2);

            // Assert
            Assert.False(result);
        }
    }
}
