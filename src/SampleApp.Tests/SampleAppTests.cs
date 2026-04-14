using Xunit;

namespace SampleApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = Program.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Greet_ValidName_ReturnsGreeting()
        {
            // Act
            string result = Program.Greet("Di");

            // Assert
            Assert.Equal("Hello, Di!", result);
        }

        [Fact]
        public void Greet_EmptyName_ThrowsException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => Program.Greet("")
            );
        }
    }
}
