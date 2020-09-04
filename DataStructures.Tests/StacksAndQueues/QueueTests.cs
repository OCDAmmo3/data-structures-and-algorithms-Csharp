using DataStructures.StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests.StacksAndQueues
{
    public class QueueTests
    {
        [Fact]
        public void Enqueue_adds_node_to_the_end_of_the_queue()
        {
            // Arrange
            Queue queue = new Queue();

            // Act
            queue.Enqueue(1);
            queue.Enqueue("two");
            queue.Enqueue(3);

            // Assert
            Assert.Equal(3, queue.Length);
            Assert.Equal("1, two, 3", queue.ToString());
        }

        [Fact]
        public void Dequeue_removes_front_value_from_list()
        {
            // Arrange
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("two");
            queue.Enqueue(3);

            // Act
            queue.Dequeue();

            // Assert
            Assert.Equal(2, queue.Length);
            Assert.Equal("two, 3", queue.ToString());
        }

        [Fact]
        public void Dequeue_throws_exception_for_empty_queue()
        {
            // Arrange
            Queue queue = new Queue();

            // Assert
            Exception ex = Assert.Throws<EmptyQueueException>(() =>
            {
                // Act
                queue.Dequeue();
            });
            Assert.Equal("This queue is empty. Cannot dequeue.", ex.Message);
        }

        [Fact]
        public void Peek_returns_value_of_front_node()
        {
            // Arrange
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue(4);

            // Act
            object result = queue.Peek();

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Peek_throws_exception_for_empty_queue()
        {
            // Arrange
            Queue queue = new Queue();

            // Assert
            Exception ex = Assert.Throws<EmptyQueueException>(() =>
            {
                // Act
                queue.Peek();
            });
            Assert.Equal("This queue is empty. Cannot peek.", ex.Message);
        }

        [Fact]
        public void IsEmpty_returns_true_for_empty_list()
        {
            // Arrange
            Queue queue = new Queue();

            // Act
            bool result = queue.IsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_returns_false_for_nonempty_list()
        {
            // Arrange
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Act
            bool result = queue.IsEmpty();

            // Assert
            Assert.False(result);
        }
    }
}
