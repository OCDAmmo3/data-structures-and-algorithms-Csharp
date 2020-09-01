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
        public void ToString_returns_null_on_empty_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act + Assert
            Assert.Equal("null", list.ToString());
        }

        [Fact]
        public void Includes_returns_true_for_values_in_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            // Act + Assert
            Assert.True(list.Includes(2));
        }

        [Fact]
        public void Includes_returns_false_for_values_not_in_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);

            // Act + Assert
            Assert.False(list.Includes(14));
        }

        [Fact]
        public void Append_adds_given_value_to_end_of_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            // Act
            list.Append(1);

            // Assert
            Assert.Equal("{ 4 } -> { 3 } -> { 2 } -> { 1 } -> null", list.ToString());
        }

        [Fact]
        public void Append_adds_given_value_on_empty_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Append(1);

            // Act + Assert
            Assert.Equal("{ 1 } -> null", list.ToString());
        }

        [Fact]
        public void InsertBefore_adds_second_given_value_into_list_before_first_given_value()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            // Act
            list.InsertBefore(3, 7);

            // Assert
            Assert.Equal("{ 4 } -> { 7 } -> { 3 } -> { 2 } -> { 1 } -> null", list.ToString());
        }

        [Fact]
        public void InsertBefore_breaks_if_value_is_not_in_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            try
            {
                list.InsertBefore(3, 7);
            }
            catch (ArgumentException aex)
            {
                // Assert
                Assert.Equal("Value given to insert before is not in list.", aex.Message);
            }
        }

        [Fact]
        public void InsertAfter_adds_second_given_value_into_list_after_first_given_value()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            // Act
            list.InsertAfter(3, 7);

            // Assert
            Assert.Equal("{ 4 } -> { 3 } -> { 7 } -> { 2 } -> { 1 } -> null", list.ToString());
        }

        [Fact]
        public void InsertAfter_breaks_if_value_is_not_in_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            try
            {
                list.InsertAfter(3, 7);
            }
            catch (ArgumentException aex)
            {
                // Assert
                Assert.Equal("Value given to insert after is not in list.", aex.Message);
            }
        }

        [Fact]
        public void Size_starts_at_zero_in_new_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act + Assert
            Assert.Equal(0, list.Size);
        }

        [Fact]
        public void Size_grows_from_each_method()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);
            list.Append(2);
            list.InsertBefore(2, 3);
            list.InsertAfter(2, 4);

            // Assert
            Assert.Equal(4, list.Size);
        }
    }
}