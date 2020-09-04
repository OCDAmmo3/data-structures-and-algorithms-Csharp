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
        public void Push_can_push_any_value_type()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("one");
            stack.Push(2);

            // Assert
            Assert.Equal(2, stack.Size);
        }
    }
}
