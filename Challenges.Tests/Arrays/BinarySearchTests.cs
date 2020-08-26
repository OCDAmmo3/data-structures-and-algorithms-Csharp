using System;
using System.Collections.Generic;
using System.Text;
using Challenges.Arrays;
using Xunit;

namespace Challenges.Tests.Arrays
{
    public class BinarySearchTests
    {
        [Fact]
        public static void Search_should_return_index_of_given_value()
        {
            // Arrange
            int[] array = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int value = 6;

            // Act
            int result = BinarySearch.Search(value, array);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public static void Search_should_return_negative_1_given_value_that_is_not_in_array()
        {
            // Arrange
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int value = 6;

            // Act
            int result = BinarySearch.Search(value, array);

            // Assert
            Assert.Equal(-1, result);
        }
        /*
        [Fact]
        public static void Search_given_array_with_the_same_value_multiple_times_should_return_a_single_instance_index()
        {
            // Arrange
            int[] array = new int[6] { 1, 1, 2, 3, 4, 5 };
            int value = 1;

            // Act
            int result = BinarySearch.Search(value, array);

            // Assert
            // ================= SHARE WITH KEITH TO SEE IF YOU CAN CHECK AGAINST BOTH 0 AND 1 ===========
            Assert.Equal(1, result);
        } */
    }
}
