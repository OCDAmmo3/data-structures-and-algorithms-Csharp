using System;
using System.Text;
using Xunit;
using DataStructures.StacksAndQueues;

namespace DataStructures.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Shelter_starts_empty()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();

            // Act
            bool result = shelter.EmptyShelter();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Shelter_can_add_animals()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();

            // Act
            shelter.AEnqueue(Animal.Type.Dog);
            bool result = shelter.EmptyShelter();

            // Assert
            Assert.Equal(1, shelter.Length);
            Assert.False(result);
        }

        [Fact]
        public void ADequeue_returns_dog()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();
            shelter.AEnqueue(Animal.Type.Dog);
            shelter.AEnqueue(Animal.Type.Cat);

            // Act
            Animal.Type? result = shelter.ADequeue(Animal.Type.Dog);

            // Assert
            Assert.Equal(Animal.Type.Dog, result);
        }

        [Fact]
        public void ADequeue_returns_next_in_line_for_no_argument()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();
            shelter.AEnqueue(Animal.Type.Dog);
            shelter.AEnqueue(Animal.Type.Cat);
            shelter.AEnqueue(Animal.Type.Cat);
            Assert.Equal(3, shelter.Length);

            // Act
            Animal.Type? result = shelter.ADequeue();

            // Assert
            Assert.Equal(Animal.Type.Dog, result);
            Assert.Equal(2, shelter.Length);
        }

        [Fact]
        public void ADequeue_can_work_as_two_different_overloads()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();
            shelter.AEnqueue(Animal.Type.Dog);
            shelter.AEnqueue(Animal.Type.Dog);
            shelter.AEnqueue(Animal.Type.Cat);
            shelter.AEnqueue(Animal.Type.Cat);
            Assert.Equal(4, shelter.Length);

            // Act
            Animal.Type? result1 = shelter.ADequeue();
            Animal.Type? result2 = shelter.ADequeue(Animal.Type.Cat);
            Animal.Type? result3 = shelter.ADequeue();

            // Assert
            Assert.Equal(1, shelter.Length);
            Assert.Equal(Animal.Type.Dog, result1);
            Assert.Equal(Animal.Type.Cat, result2);
            Assert.Equal(Animal.Type.Dog, result3);
        }
    }
}