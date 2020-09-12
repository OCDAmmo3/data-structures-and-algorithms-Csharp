using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
