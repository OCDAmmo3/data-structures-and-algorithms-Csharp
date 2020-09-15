using Xunit;
using DataStructures.Trees;
using System;

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
        public static BinaryTree<int> CreateTreeInt()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new BinaryTree<int>.Node(1);
            tree.Root.Left = new BinaryTree<int>.Node(8);
            tree.Root.Right = new BinaryTree<int>.Node(2);
            tree.Root.Left.Left = new BinaryTree<int>.Node(63);
            tree.Root.Left.Right = new BinaryTree<int>.Node(1234);
            tree.Root.Right.Left = new BinaryTree<int>.Node(94);
            tree.Root.Right.Right = new BinaryTree<int>.Node(23);
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

        [Fact]
        public void FindMaxValue_returns_max_value()
        {
            // Arrange
            BinaryTree<int> tree = CreateTreeInt();

            // Act
            int result = tree.FindMaximumValue();

            // Assert
            Assert.Equal(1234, result);
        }

        [Fact]
        public void FindMaxValue_returns_exception_on_string_tree_or_empty_tree()
        {
            // Arrange
            BinaryTree<string> tree1 = CreateTree();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            // Assert 1
            Exception ex1 = Assert.Throws<NotIntTreeException>(() =>
            {
                // Act 1
                tree1.FindMaximumValue();
            });
            Assert.Equal("I only work for int trees.", ex1.Message);

            // Assert 2
            Exception ex2 = Assert.Throws<EmptyTreeException>(() =>
            {
                // Act 2
                tree2.FindMaximumValue();
            });
            Assert.Equal("This tree is empty. No maximum value.", ex2.Message);
        }

        [Fact]
        public void BreadthFirst_returns_values_in_a_breadth_first_traversal()
        {
            // Arrange
            BinaryTree<string> tree1 = CreateTree();
            BinaryTree<int> tree2 = CreateTreeInt();

            // Act
            string result1 = tree1.BreadthFirst();
            string result2 = tree2.BreadthFirst();

            // Assert
            Assert.Equal("Root, RootLeft, RootRight, RootLeftLeft, RootLeftRight, RootRightLeft, RootRightRight", result1);
            Assert.Equal("1, 8, 2, 63, 1234, 94, 23", result2);
        }
    }
}
