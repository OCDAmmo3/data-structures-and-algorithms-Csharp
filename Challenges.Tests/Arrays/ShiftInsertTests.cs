using System;
using System.Collections.Generic;
using System.Text;
using Challenges.Arrays;
using Xunit;

namespace Challenges.Tests.Arrays
{
    public class ShiftInsertTests
    {
        [Fact]
        public static void ShiftInserter_insert_value_into_middle_of_even_array()
        {
            // Arrange
            int value = 3;
            int[] array = new int[4] { 1, 2, 4, 5 };

            // Act
            int[] result = ShiftInsert.ShiftInserter(array, value);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public static void ShiftInserter_inserts_value_into_middle_of_odd_array()
        {
            // Arrange
            int value = 3;
            int[] array = new int[4] { 1, 2, 4, 5 };

            // Act
            int[] result = ShiftInsert.ShiftInserter(array, value);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public static void ShiftInsert_inserts_new_value_for_length_0_array()
        {
            // Arrange
            int value = 3;
            int[] array = new int[0];

            // Act
            int[] result = ShiftInsert.ShiftInserter(array, value);

            // Assert
            Assert.Equal(new[] { 3 }, result);
        }

        [Fact]
        public static void ShiftInsert_inserts_new_value_for_length_1_array()
        {
            // Arrange
            int value = 3;
            int[] array = new int[1] { 1 };

            // Act
            int[] result = ShiftInsert.ShiftInserter(array, value);

            // Assert
            Assert.Equal(new[] { 1, 3 }, result);
        }
    }
}
