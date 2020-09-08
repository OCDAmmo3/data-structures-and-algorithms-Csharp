using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.StacksAndQueues;
using Xunit;

namespace DataStructures.Tests.StacksAndQueues
{
    public class StacksTests
    {
        [Fact]
        public void Push_can_push_any_value_type_and_ToString_works()
        {
            // Arrange
            Stack stack = new Stack();

            // Act 1
            stack.Push("one");

            //Assert 1
            Assert.Equal(1, stack.Size);
            Assert.Equal("one", stack.ToString());

            // Act 2
            stack.Push(2);

            // Assert 2
            Assert.Equal(2, stack.Size);
            Assert.Equal("2, one", stack.ToString());
        }

        [Fact]
        public void Pop_removes_the_top_node_and_returns_value()
        {
            // Arrange
            Stack stack = new Stack();
            stack.Push(1000000);
            Assert.Equal(1, stack.Size);
            stack.Push("hello");
            Assert.Equal(2, stack.Size);

            // Act
            object result = stack.Pop();

            // Assert
            Assert.Equal(1, stack.Size);
            Assert.Equal("1000000", stack.ToString());
            Assert.Equal("hello", result);
        }

        [Fact]
        public void Pop_can_make_a_list_empty()
        {
            // Arrange
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Size);
            stack.Push(2);
            Assert.Equal(2, stack.Size);
            stack.Push("three");
            Assert.Equal(3, stack.Size);

            // Act
            object result1 = stack.Pop();
            Assert.Equal(2, stack.Size);
            object result2 = stack.Pop();
            Assert.Equal(1, stack.Size);
            object result3 = stack.Pop();
            Assert.Equal(0, stack.Size);

            object[] results = new object[] { result1, result2, result3 };

            // Assert
            Assert.Equal(new object[] { "three", 2, 1 }, results);
        }

        [Fact]
        public void Pop_throws_upon_empty_stack()
        {
            // Arrange
            Stack stack = new Stack();

            // Assert
            Exception ex = Assert.Throws<EmptyStackException>(() =>
            {
                // Act
                stack.Pop();
            });
            // Assert
            Assert.Equal("This list is empty. Cannot pop.", ex.Message);
        }

        [Fact]
        public void Peek_returns_the_value_from_the_top_of_the_stack()
        {
            // Arrange
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push("three");

            // Act
            object result = stack.Peek();

            // Assert
            Assert.Equal(3, stack.Size);
            Assert.Equal("three", result);
        }

        [Fact]
        public void Peek_throws_upon_empty_stack()
        {
            // Arrange
            Stack stack = new Stack();

            // Assert
            Exception ex = Assert.Throws<EmptyStackException>(() =>
            {
                // Act
                stack.Peek();
            });
            // Assert
            Assert.Equal("This list is empty. Cannot peek.", ex.Message);
        }

        [Fact]
        public void IsEmpty_returns_true_for_empty_list()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            bool result = stack.IsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_returns_false_for_nonempty_list()
        {
            // Arrange
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("two");

            // Act
            bool result = stack.IsEmpty();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ToString_returns_properly_if_empty_stack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            string result = stack.ToString();

            // Assert
            Assert.Equal("null", result);
        }
    }
}
