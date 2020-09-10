using DataStructures.StacksAndQueues;
using System;
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
            Queue<string> queue = new Queue<string>();

            // Act
            queue.Enqueue("1");
            queue.Enqueue("two");
            queue.Enqueue("3");

            // Assert
            Assert.Equal(3, queue.Length);
            Assert.Equal("1, two, 3", queue.ToString());
        }

        [Fact]
        public void Dequeue_removes_front_value_from_list()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Act
            queue.Dequeue();

            // Assert
            Assert.Equal(2, queue.Length);
            Assert.Equal("2, 3", queue.ToString());
        }

        [Fact]
        public void Dequeue_throws_exception_for_empty_queue()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

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
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("4");

            // Act
            string result = queue.Peek();

            // Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void Peek_throws_exception_for_empty_queue()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();

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
            Queue<int> queue = new Queue<int>();

            // Act
            bool result = queue.IsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_returns_false_for_nonempty_list()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Act
            bool result = queue.IsEmpty();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Enqueue_dequeue_patterns_do_not_mess_with_each_other()
        {
            // This is a series of enqueues and dequeues and constant checks to make sure that bugs aren't present as the queue grows and shrinks
            Queue<int> queue = new Queue<int>();
            Assert.Equal(0, queue.Length);

            queue.Enqueue(1);
            Assert.Equal(1, queue.Length);
            queue.Enqueue(2);
            Assert.Equal(2, queue.Length);
            Assert.Equal("1, 2", queue.ToString());

            object dq1 = queue.Dequeue();
            Assert.Equal(1, queue.Length);
            Assert.Equal(1, dq1);
            object dq2 = queue.Dequeue();
            Assert.Equal(0, queue.Length);
            Assert.Equal(2, dq2);

            queue.Enqueue(1);
            Assert.Equal("1", queue.ToString());
            Assert.Equal(1, queue.Length);
            object dq3 = queue.Dequeue();
            Assert.Equal(0, queue.Length);
            Assert.Equal(1, dq3);
        }

        [Fact]
        public void ToString_returns_properly_for_empty_queue()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act
            string result = queue.ToString();

            // Assert
            Assert.Equal("null", result);
        }
    }
}
