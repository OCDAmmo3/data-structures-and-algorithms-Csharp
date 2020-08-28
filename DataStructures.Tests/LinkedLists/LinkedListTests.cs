using System;
using System.Text;
using Xunit;
using DataStructures.LinkedLists;

namespace DataStructures.Tests.LinkedLists
{
    public class LinkedListTests
    {
        [Fact]
        public void LinkedList_starts_empty()
        {
            // Act
            LinkedList list = new LinkedList();

            // Assert
            Assert.Equal("null", list.ToString());
        }

        [Fact]
        public void Insert_adds_value_to_start()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);

            // Assert
            Assert.Equal("{ 1 } -> null", list.ToString());

            // Act2
            list.Insert(2);

            // Assert2
            Assert.Equal("{ 2 } -> { 1 } -> null", list.ToString());
        }

        [Fact]
        public void Includes_returns_true_for_values_in_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            // Act
            bool result = list.Includes(2);

            // Assert
            Assert.True(result);
        }
    }
}
