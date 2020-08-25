using System;
using System.Collections.Generic;
using System.Text;
using Challenges.Arrays;
using Xunit;

namespace Challenges.Tests.Arrays
{
    public class ReverseTests
    {
        [Fact]
        public void ReverseArray_reverses_an_empty_array()
        {
            // Arrange
            int[] array = new int[0];

            // Act
            int[] result = Reverse.ReverseArray(array);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ReverseArray_reverses_an_array_with_numbers_1_to_5()
        {
            // Arrange
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            // Act
            int[] result = Reverse.ReverseArray(array);

            // Assert
            Assert.Equal(5, result.Length);
            Assert.Equal(new[] { 5, 4, 3, 2, 1 }, result);
        }
    }
}
