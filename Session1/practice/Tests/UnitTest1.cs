using Xunit;
using UnitTestingBasics;

namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
