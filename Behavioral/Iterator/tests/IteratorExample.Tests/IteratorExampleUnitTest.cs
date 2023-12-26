using IteratorExample.Aggregate;
using IteratorExample.Models;

namespace IteratorExample.Tests
{
    public class IteratorExampleUnitTest
    {
        private readonly ConcreteCollection collection;
        private readonly Elempoyee employee1 = new("John Doe", 1);
        private readonly Elempoyee employee2 = new("John Doe", 2);

        // Constructor of the test class
        public IteratorExampleUnitTest()
        {
            // Initialize the collection with some default data
            collection = new ConcreteCollection();
            collection.AddEmployee(employee1);
            collection.AddEmployee(employee2);
        }

        [Fact]
        public void WhenConcreteCollectionAddsEmployees_ThenSuccessfully()
        {
            // Assert
            Assert.Equal(2, collection.Count);
        }

        [Fact]
        public void WhenCreateIterator_ThenReturnsIteratorInstance()
        {
            // Act
            Iterator.Iterator iterator = collection.CreateIterator();

            // Assert
            _ = Assert.IsType<Iterator.Iterator>(iterator);
        }

        [Fact]
        public void WhenIterator_ThenCorrectlyIteratesOverCollection()
        {
            Iterator.Iterator iterator = collection.CreateIterator();

            // Act & Assert
            Assert.Equal(employee1, iterator.First());
            Assert.Equal(employee2, iterator.Next());
        }

        [Fact]
        public void WhenIteratorEnds_ThenIterationAtEndOfCollection()
        {
            // Arrange
            Iterator.Iterator iterator = collection.CreateIterator();

            // Act
            _ = iterator.Next();
            _ = iterator.Next();

            // Assert
            Assert.True(iterator.IsCompleted);
        }
    }
}