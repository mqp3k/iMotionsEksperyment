namespace SumMultiples_UnitTesting;

public class SumMultiplesTests
{
    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit10()
    {
        // Arrange
        int limit = 10;
        int expectedSum = 23; // Suma wielokrotności 3 lub 5 poniżej 10

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit20()
    {
        // Arrange
        int limit = 20;
        int expectedSum = 78; // Suma wielokrotności 3 lub 5 poniżej 20

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit1000()
    {
        // Arrange
        int limit = 1000;
        int expectedSum = 233168; // Suma wielokrotności 3 lub 5 poniżej 1000

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsZero_ForLimit1()
    {
        // Arrange
        int limit = 1;
        int expectedSum = 0; // Suma wielokrotności 3 lub 5 poniżej 1

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsZero_ForNegativeLimit()
    {
        // Arrange
        int limit = -10;
        int expectedSum = 0; // Suma wielokrotności 3 lub 5 poniżej -10

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }
}