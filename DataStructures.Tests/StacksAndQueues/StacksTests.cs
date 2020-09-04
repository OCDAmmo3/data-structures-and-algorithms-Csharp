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
        public void Pop_removes_the_top_node()
        {
            // Arrange
            Stack stack = new Stack();
            stack.Push(1000000);
            Assert.Equal(1, stack.Size);
            stack.Push("hello");
            Assert.Equal(2, stack.Size);

            // Act
            stack.Pop();

            // Assert
            Assert.Equal(1, stack.Size);
            Assert.Equal("1000000", stack.ToString());
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
    }
}
