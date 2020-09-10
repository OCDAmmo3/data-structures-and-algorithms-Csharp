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
    }
}