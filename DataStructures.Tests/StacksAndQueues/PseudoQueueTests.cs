using DataStructures.StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests.StacksAndQueues
{
    public class PseudoQueueTests
    {
        [Fact]
        public void Enqueue_adds_node_to_front_of_pseudoQueue()
        {
            // Arrange
            PseudoQueue pQueue = new PseudoQueue();

            // Act
            pQueue.Enqueue(4);

            // Assert
            Assert.Equal(1, pQueue.Length);
            Assert.True(pQueue is IQueue);
        }

        [Fact]
        public void Dequeue_removes_node_from_front_of_pseudoQueue()
        {
            // Arrange
            PseudoQueue pQueue = new PseudoQueue();
            pQueue.Enqueue(3);
            pQueue.Enqueue("four");
            pQueue.Enqueue(5);
            Assert.Equal(3, pQueue.Length);

            // Act
            object result = pQueue.Dequeue();

            // Assert
            Assert.Equal(2, pQueue.Length);
            Assert.Equal(3, result);

            // Act2
            object result2 = pQueue.Dequeue();

            // Assert2
            Assert.Equal(1, pQueue.Length);
            Assert.Equal("four", result2);

            // Act3
            object result3 = pQueue.Dequeue();

            // Assert3
            Assert.Equal(0, pQueue.Length);
            Assert.Equal(5, result3);
        }
    }
}
