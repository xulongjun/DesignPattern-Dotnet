using StrategyExample.Context;
using StrategyExample.Strategy;

namespace StrategyExaple.Tests
{
    public class StrategyExampleUnitTest
    {
        private CompressionContext CreateContextWithStrategy(ICompression compressionStrategy)
        {
            return new CompressionContext(compressionStrategy);
        }

        [Theory]
        [InlineData("testArchive", "Folder is compressed using Rar approach: 'testArchive.rar' file is created")]
        [InlineData("myData", "Folder is compressed using Rar approach: 'myData.rar' file is created")]
        public void GivenRarStrategy_WhenCreateArchive_ThenCorrectMessageIsSet(string archiveName, string expectedMessage)
        {
            // Arrange
            var rarCompression = new RarCompression();
            var context = CreateContextWithStrategy(rarCompression);

            // Act
            context.CreateArchive(archiveName);

            // Assert
            Assert.Equal(expectedMessage, rarCompression.MessageTest);
        }

        [Theory]
        [InlineData("testArchive", "Folder is compressed using zip approach: 'testArchive.rar' file is created")]
        [InlineData("myData", "Folder is compressed using zip approach: 'myData.rar' file is created")]
        public void GivenZipStrategy_WhenCreateArchive_ThenCorrectMessageIsSet(string archiveName, string expectedMessage)
        {
            // Arrange
            var zipCompression = new ZipCompression();
            var context = CreateContextWithStrategy(zipCompression);

            // Act
            context.CreateArchive(archiveName);

            // Assert
            Assert.Equal(expectedMessage, zipCompression.MessageTest);
        }

        [Fact]
        public void GivenStrategyChange_WhenCreateArchive_ThenUsesNewStrategy()
        {
            // Arrange
            var rarCompression = new RarCompression();
            var zipCompression = new ZipCompression();
            var context = CreateContextWithStrategy(rarCompression);

            // Act
            context.SetStrategy(zipCompression);
            context.CreateArchive("dynamicStrategy");

            // Assert
            Assert.Null(rarCompression.MessageTest);
            Assert.Equal("Folder is compressed using zip approach: 'dynamicStrategy.rar' file is created", zipCompression.MessageTest);
        }
    }
}