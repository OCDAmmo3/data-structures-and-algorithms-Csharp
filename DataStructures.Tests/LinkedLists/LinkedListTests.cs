using System;
using System.Text;
using Xunit;
using DataStructures.LinkedLists;
using Challenges.LinkedLists;

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

            // Assert
            Exception ex = Assert.Throws<ValueMissingException>(() =>
            {
                // Act
                list.InsertBefore(3, 7);
            });
            Assert.Equal("Value 3 is not in list.", ex.Message);
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

            // Assert
            Exception ex = Assert.Throws<ValueMissingException>(() =>
            {
                // Act
                list.InsertAfter(3, 7);
            });
            // Assert
            Assert.Equal("Value 3 is not in list.", ex.Message);
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

        [Fact]
        public void KthFromEnd_throws_on_too_big_value()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);

            // Assert
            Exception ex = Assert.Throws<ValueTooLargeException>(() =>
            {
                // Act
                list.KthFromEnd(5);
            });
            Assert.Equal("Value 5 is too big for this list.", ex.Message);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        public void KthFromEnd_returns_the_kth_value_from_the_end(int k, int expected)
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);

            // Act
            int result = list.KthFromEnd(k);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void KthFromEnd_returns_value_for_length_one_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);

            // Act
            int result = list.KthFromEnd(0);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void KthFromEnd_makes_negative_positive()
        {
            // Arrange
            LinkedList list = new LinkedList();
            for (int i = 1; i <= 10; i++)
                list.Insert(i);

            // Act
            int result = list.KthFromEnd(-2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void KthFromEnd_throws_on_empty_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            int value = 0;

            // Assert
            Exception ex = Assert.Throws<ValueTooLargeException>(() =>
            {
                // Act
                list.KthFromEnd(value);
            });
            Assert.Equal($"Value {value} is too big for this list.", ex.Message);
        }

        [Fact]
        public void ToArray_returns_array_with_all_list_values()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            // Act
            int[] result = list.ToArray();

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4 }, result);
        }

        [Fact]
        public void ToArray_returns_empty_array_length_0_on_empty_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            int[] result = list.ToArray();

            // Assert
            Assert.Equal(new int[0], result);
        }

        [Fact]
        public void Zipper_returns_1_list_of_2_lists_alternating_values()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(2);
            list1.Insert(4);
            list1.Insert(6);

            list2.Insert(1);
            list2.Insert(3);
            list2.Insert(5);

            LinkedList expected = new LinkedList();
            expected.Insert(1);
            expected.Insert(2);
            expected.Insert(3);
            expected.Insert(4);
            expected.Insert(5);
            expected.Insert(6);

            // Act
            LinkedList result = LLChallenges.Zipper(list1, list2);

            // Assert
            Assert.Equal(expected.ToString(), result.ToString());
        }

        [Fact]
        public void Zipper_returns_properly_if_lists_are_different_lengths()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(4);

            list2.Insert(1);
            list2.Insert(2);
            list2.Insert(3);

            LinkedList expected = new LinkedList();
            expected.Insert(1);
            expected.Insert(2);
            expected.Insert(3);
            expected.Insert(4);

            // Act
            LinkedList result = LLChallenges.Zipper(list1, list2);

            // Assert
            Assert.Equal("{ 4 } -> null", list1.ToString());
            Assert.Equal("{ 3 } -> { 2 } -> { 1 } -> null", list2.ToString());
            Assert.Equal(expected.ToString(), result.ToString());
        }

        [Fact]
        public void Zipper_returns_properly_if_list_1_has_more_values()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(0);
            list1.Insert(1);
            list1.Insert(3);
            list1.Insert(5);

            list2.Insert(2);
            list2.Insert(4);

            LinkedList expected = new LinkedList();
            expected.Insert(0);
            expected.Insert(1);
            expected.Insert(2);
            expected.Insert(3);
            expected.Insert(4);
            expected.Insert(5);


            // Act
            LinkedList result = LLChallenges.Zipper(list1, list2);

            // Assert
            Assert.Equal(expected.ToString(), result.ToString());
        }
    }
}